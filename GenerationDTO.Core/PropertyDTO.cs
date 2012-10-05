using System.Collections.Generic;

namespace GenerationDTO.Core
{
    public class PropertyDTO
    {
        string _name;
        string _type;
        List<string> _requires;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool IsRequired { get; set; }

        public string GetPrivateName()
        {
            return "_" + ToCamelCase(_name);
        }

        public string GetCamelCasedName()
        {
            return ToCamelCase(_name);
        }

        public string GetPascalCasedName()
        {
            return ToPascalCase(_name);
        }

        private void AddRequires(string requirement)
        {
            _requires.Add(string.Format("Contract.Requires({0});", requirement));
        }

        public List<string> GetRequires()
        {
            _requires = new List<string>();
            string require = string.Empty;

            if (IsRequired)
            {
                switch (_type)
                {
                    case "string":
                        require = string.Format("!string.IsNullOrEmpty({0})", _name);
                        AddRequires(require);
                        break;
                    case "Guid":
                        require = string.Format("{0} != Guid.Empty", _name);
                        AddRequires(require);
                        break;
                }
            }

            return _requires;
        }



        string ToCamelCase(string phrase)
        {
            string result = string.Empty;

            if (phrase.Length > 0)
            {
                result = phrase.Substring(0, 1).ToLower();
                result += phrase.Substring(1, phrase.Length - 1);
            }

            return result;
        }

        string ToPascalCase(string phrase)
        {
            string result = string.Empty;

            if (phrase.Length > 0)
            {
                result = phrase.Substring(0, 1).ToUpper();
                result += phrase.Substring(1, phrase.Length - 1);
            }

            return result;
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
