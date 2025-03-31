using System.Drawing.Text;

namespace ExpenseTracker {
    public static class Static {
        public static string EmbeddedMaterialFontPath = "ExpenseTracker.Fonts.MaterialSymbolsOutlined[FILL,GRAD,opsz,wght].ttf";
        public static string EmbeddedMaterialFontCodePointsPath = "ExpenseTracker.Fonts.MaterialSymbolsOutlined[FILL,GRAD,opsz,wght].codepoints.txt";

        // store custom fonts so they won't get GC'd
        private static PrivateFontCollection pfc = new PrivateFontCollection();

        public static bool MaterialFontLoaded { get; private set; } = false;

        public static void LoadMaterialFont() {


            var assembly = typeof(MainForm).Assembly;
            using (Stream fontStream = assembly.GetManifestResourceStream(Static.EmbeddedMaterialFontPath)) {
                if (fontStream == null)
                    throw new Exception("Could not find embedded font resource, check your resource path man.");
                // create a buffer to read in
                byte[] data = new byte[fontStream.Length];
                fontStream.Read(data, 0, (int)fontStream.Length);


                // pin array
                System.IntPtr ptrData = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(data.Length);
                System.Runtime.InteropServices.Marshal.Copy(data, 0, ptrData, data.Length);

                // add to the private font collection
                pfc.AddMemoryFont(ptrData, data.Length);

                // free up
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(ptrData);
                MaterialFontLoaded = true;
            }


        }

        public static Font GetMaterialFont(int size, FontStyle fs = FontStyle.Regular) {

            if (!MaterialFontLoaded) {
                LoadMaterialFont();
            }

            return new Font(pfc.Families[0], size, FontStyle.Regular);

        }
    }
}
