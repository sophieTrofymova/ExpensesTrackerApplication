using Newtonsoft.Json;

namespace ExpenseTracker.Storage
{
    public class PathsRegistry
    {
        [JsonProperty]
        private readonly Dictionary<string, string> paths;

        public PathsRegistry()
        {
            paths = new Dictionary<string, string>();
        }

        public string GetFilename(string label)
        {
            if (paths.TryGetValue(label, out string filename))
            {
                return filename;
            }
            throw new KeyNotFoundException($"Path with label '{label}' does not exist.");
        }

        public void AddPath(string label, string filename)
        {
            if (string.IsNullOrWhiteSpace(label))
                throw new ArgumentException("Label cannot be null or empty.", nameof(label));

            if (string.IsNullOrWhiteSpace(filename))
                throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));

            if (paths.ContainsKey(label))
                throw new InvalidOperationException($"A path with the label '{label}' already exists.");

            paths[label] = filename;
        }

        public void RemovePath(string label)
        {
            if (!paths.Remove(label))
            {
                throw new KeyNotFoundException($"Path with label '{label}' was not found.");
            }
        }

        /// <summary>
        /// Ensures that registry contains path record
        /// </summary>
        /// <param name="label">Path label</param>
        /// <param name="filename">Path filename</param>
        public void EnsurePathRegistered(string label, string filename)
        {
            if (!PathExists(label))
            {
                AddPath(label, filename);
            }
        }

        public bool PathExists(string label)
        {
            return paths.ContainsKey(label);
        }

        public Dictionary<string, string> GetAllPaths()
        {
            return new Dictionary<string, string>(paths); // Returns a copy to prevent external modification
        }
    }
}
