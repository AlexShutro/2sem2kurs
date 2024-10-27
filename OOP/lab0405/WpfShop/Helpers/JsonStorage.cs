using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WpfShop {
    internal class JsonStorage<T> {
        private string _storageFile;

        public JsonStorage(string storageFile) {
            _storageFile = storageFile;
            if (!File.Exists(_storageFile)) {
                File.Create(_storageFile);
            }
        }

        public string Serialize(T obj) {
            return JsonConvert.SerializeObject(obj);
        }

        public T Deserialize(string json) {
            return JsonConvert.DeserializeObject<T>(json);
        }

        private void Write(string text) {
            File.WriteAllText(_storageFile, text);
        }

        public string Read() {
            return File.ReadAllText(_storageFile);
        }

        public void Save(T data) {
            Write(Serialize(data));
        }

        public T Load() {
            return Deserialize(Read());
        }
    }
}
