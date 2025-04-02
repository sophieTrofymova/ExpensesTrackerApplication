using System.Drawing.Text;
using System.Reflection;

namespace ExpenseTracker {



    public static class MaterialFont {

        public static bool UseEmbeddedLoad { get; set; } = true;
        public static string FontFileName = "MaterialSymbolsOutlined[FILL,GRAD,opsz,wght].ttf";
        public static string CodePointsFilename = "MaterialSymbolsOutlined[FILL,GRAD,opsz,wght].codepoints.txt";
        public static string EmbeddedFontPath = "ExpenseTracker.Fonts.MaterialSymbolsOutlined[FILL,GRAD,opsz,wght].ttf";
        public static string EmbeddedCodePointsPath = "ExpenseTracker.Fonts.MaterialSymbolsOutlined[FILL,GRAD,opsz,wght].codepoints.txt";

        private static PrivateFontCollection MaterialFontCollection = new PrivateFontCollection();
        private static Dictionary<string, string> CodePoints = new() { };
        private static bool IsFontLoaded { get; set; } = false;
        private static bool IsCodePointsLoaded { get; set; } = false;

        public static void Initialize() {
            if (!IsFontLoaded) LoadFont();
            if (!IsCodePointsLoaded) LoadCodePoints();
        }


        private static void LoadFont() {

            if (UseEmbeddedLoad) {
                IsFontLoaded = MaterialFontCollection.AddFontFromEmbeddedFile(EmbeddedFontPath);
            }
            else {
                IsFontLoaded = MaterialFontCollection.AddFontFromFile(FontFileName);
            }

            if (!IsFontLoaded) {
                throw new Exception($"Unable to load font from: {FontFileName}");
            }
        }
        private static void LoadCodePoints() {

            Dictionary<string, string>? codePoints = null;

            codePoints = (UseEmbeddedLoad) ?
                LoadCodepointsFromEmbeddedFile(EmbeddedCodePointsPath) :
                LoadCodepointsFromFile(CodePointsFilename);
            if (codePoints == null) {
                throw new Exception($"Unable to load embedded codepoints file at: {EmbeddedCodePointsPath}");
            }

            CodePoints = codePoints;
            IsCodePointsLoaded = true;
        }

        private static Dictionary<string, string>? LoadCodepointsFromEmbeddedFile(string embeddedFilename) {

            var assembly = typeof(MaterialFont).Assembly;
            using var stream = assembly.GetManifestResourceStream(embeddedFilename);

            if (stream == null)
                return null;

            var icons = new Dictionary<string, string>();


            using var reader = new StreamReader(stream);
            while (!reader.EndOfStream) {
                var line = reader.ReadLine();
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2) continue;

                var name = parts[0];
                var codepoint = parts[1];

                if (!icons.ContainsKey(name))
                    icons.Add(name, codepoint);
            }

            return icons;
        }

        private static Dictionary<string, string>? LoadCodepointsFromFile(string filename) {

            if (!File.Exists(filename)) {
                return null;
            }


            var icons = new Dictionary<string, string>();


            foreach (var line in File.ReadAllLines(filename)) {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2) continue;

                var name = parts[0];
                var codepoint = parts[1];

                if (!icons.ContainsKey(name)) // avoid dupes
                    icons.Add(name, codepoint);
            }

            return icons;
        }

        private static bool AddFontFromEmbeddedFile(this PrivateFontCollection fontCollection, string embeddedFontPath) {
            var assembly = typeof(MaterialFont).Assembly;


            using var fontStream = assembly.GetManifestResourceStream(embeddedFontPath);
            if (fontStream == null) return false;

            // create a buffer to read in
            byte[] data = new byte[fontStream.Length];
            fontStream.Read(data, 0, (int)fontStream.Length);

            // pin array
            System.IntPtr ptrData = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(data.Length);
            System.Runtime.InteropServices.Marshal.Copy(data, 0, ptrData, data.Length);

            // add to collection
            fontCollection.AddMemoryFont(ptrData, data.Length);

            // free up
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(ptrData);

            return true;
        }

        private static bool AddFontFromFile(this PrivateFontCollection fontCollection, string fontPath) {

            // throw except if file doesn't exist
            if (!File.Exists(fontPath)) {
                return false;
            }

            // load font file into memory
            byte[] data = File.ReadAllBytes(fontPath);

            // pin array
            IntPtr ptrData = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(data.Length);
            System.Runtime.InteropServices.Marshal.Copy(data, 0, ptrData, data.Length);

            // add to collection
            fontCollection.AddMemoryFont(ptrData, data.Length);

            // free up
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(ptrData);

            return true;
        }

        public static Font GenerateFont(float size, FontStyle fs = FontStyle.Regular, GraphicsUnit gu = GraphicsUnit.Point) {
            // lazy load font
            if (!IsFontLoaded) {
                LoadFont();
            }

            return new Font(MaterialFontCollection.Families[0], size, fs, gu); // use requested style instead of always Regular
        }

        public static string GetIconCodepoint(string iconName) {

            // lazy load font
            if (!IsCodePointsLoaded) {
                LoadCodePoints();
            }
            if (CodePoints.ContainsKey(iconName)) {
                return CodePoints[iconName];
            }

            return "e000"; // else error icon codepoint
        }


        public static string GetIconByCodePoint(string codepoint) {

            if (int.TryParse(codepoint, System.Globalization.NumberStyles.HexNumber, null, out int code)) {
                return char.ConvertFromUtf32(code);
            }
            else {
                return "\uE000";
            }
        }

        public static string GetIconByName(string name) {

            return GetIconByCodePoint(GetIconCodepoint(name));

        }


    }

}
