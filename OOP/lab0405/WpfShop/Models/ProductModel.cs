using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Newtonsoft.Json;


namespace WpfShop {
    [JsonObject(MemberSerialization.OptIn)]
    public class ProductModel : INotifyPropertyChanged, IDataErrorInfo {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _id;
        private decimal _price;
        private int _rating;
        private int _quantity;
        private string _title = string.Empty;
        private ProductCategory _category = ProductCategory.Unknown;
        private string _imagePath = string.Empty;
        private string _shortDescription = string.Empty;
        private string _longDescription = string.Empty;

        [JsonProperty]
        public int ID {
            get => _id;
            set {
                if (_id == value) return;
                _id = value;
                OnPropertyChanged("ID");
            }
        }

        [JsonProperty]
        public decimal Price {
            get => _price;
            set {
                if (_price == value) return;
                _price = value;
                OnPropertyChanged("Price");
            }
        }

        [JsonProperty]
        public int Rating {
            get => _rating;
            set {
                if (_rating == value) return;
                _rating = value;
                OnPropertyChanged("Rating");
            }
        }

        [JsonProperty]
        public int Quantity {
            get => _quantity;
            set {
                if (_quantity == value) return;
                _quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        [JsonProperty]
        public string Title {
            get => _title;
            set {
                if (_title == value) return;
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        [JsonProperty]
        public ProductCategory Category {
            get => _category;
            set {
                if (_category == value) return;
                _category = value;
                OnPropertyChanged("Category");
            }
        }

        [JsonProperty]
        public string ImagePath {
            get => _imagePath;
            set {
                if (_imagePath == value) return;
                _imagePath = value;
                OnPropertyChanged("ImagePath");
            }
        }

        [JsonProperty]
        public string ShortDescription {
            get => _shortDescription;
            set {
                if (_shortDescription == value) return;
                _shortDescription = value;
                OnPropertyChanged("ShortDescription");
            }
        }

        [JsonProperty]
        public string LongDescription {
            get => _longDescription;
            set {
                if (_longDescription == value) return;
                _longDescription = value;
                OnPropertyChanged("LongDescription");
            }
        }

        public string this[string columnName] {
            get {
                string error = string.Empty;
                switch (columnName) {
                    case "ID":
                        if (ID < 0) {
                            error = "ID should be greater than 0";
                        }
                        break;
                    case "Price":
                        if (Price < 0) {
                            error = "Price should be greater than 0";
                        }
                        break;
                    case "Rating":
                        if ((Rating < 0) || (Rating > 100)) {
                            error = "Rating should be greater than 0 and less than 100";
                        }
                        break;
                    case "Quantity":
                        if (Quantity < 0) {
                            error = "Quantity should be greater than 0";
                        }
                        break;
                    case "Title":
                        if (Title.Length < 3 || Title.Length > 30) {
                            error = "Title lenght should be greater than 3 and less than 30";
                        }
                        break;
                    case "ShortDescription":
                        if (ShortDescription.Length < 5 || ShortDescription.Length > 50) {
                            error = "Short description lenght should be greater than 5 and less than 30";
                        }
                        break;
                    case "LongDescription":
                        if (LongDescription.Length < 10 || LongDescription.Length > 100) {
                            error = "Long description lenght should be greater than 10 and less than 100";
                        }
                        break;
                    case "Category":
                        if (Category == ProductCategory.Unknown) {
                            error = "Category cannot be unknown";
                        }
                        break;
                    case "ImagePath":
                        if (ImagePath.Length == 0) {
                            error = "Image path cannot be unset";
                        }
                        break;
                }
                return error;
            }
        }

        public string Error {
            get {
                string[] checkProperties = { "ID", "Price", "Rating", "Quantity", "Title", "ShortDescription", "LongDescription", "Category", "ImagePath" };
                string error = string.Empty;
                StringBuilder sb = new StringBuilder();

                foreach (string property in checkProperties) {
                    error = this[property];
                    if (error != string.Empty) {
                        sb.AppendLine(error);
                    }
                }

                return sb.ToString();
            }
        }

        protected virtual void OnPropertyChanged(string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
