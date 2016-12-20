using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bluedragon.tool.trans.common
{
    public static class TransConfig
    {
        private static MyTransSection section;

        static TransConfig ()
	    {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
            section = (MyTransSection)ConfigurationManager.GetSection("MyTrans");
	    }

        public static MyTransSection Section
        {
            get { return section; }
        }
    }

    #region  自定义配置节
    public class MyTransSection : ConfigurationSection
    {
        [ConfigurationProperty("Tran", IsDefaultCollection = true)]
        public TransCollection Tran
        {
            get
            {
                return base["Tran"] as TransCollection;
            }
        }

    }

    public class TransCollection : ConfigurationElementCollection
    {
        public TransCollection()
        {

        }

        #region Override
        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.AddRemoveClearMap;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new TranElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as TranElement).Key;
        }
        #endregion

        #region Add、Clear、Remove
        public new string AddElementName
        {
            get
            { return base.AddElementName; }

            set
            { base.AddElementName = value; }
        }

        public new string ClearElementName
        {
            get
            { return base.ClearElementName; }

            set
            { base.AddElementName = value; }
        }

        public new string RemoveElementName
        {
            get
            { return base.RemoveElementName; }
        }
        #endregion

        public new int Count
        {
            get { return base.Count; }
        }

        public TranElement this[int index]
        {
            get
            {
                return BaseGet(index) as TranElement;
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

    }

    public class TranElement : ConfigurationElement
    {
        [ConfigurationProperty("key",
            IsKey = true,
            IsRequired = true)]
        public string Key
        {
            get
            {
                return this["key"] as string;
            }
            set
            {
                this["key"] = value;
            }
        }

        [ConfigurationProperty("value",
            IsRequired = true)]
        public string Value
        {
            get
            {
                return this["value"] as string;
            }
            set
            {
                this["value"] = value;
            }
        }
    }

    public class AddElement : ConfigurationElement
    {
        [ConfigurationProperty("key",
            IsKey=true,
            IsRequired=true)]
        public string Key
        {
            get
            {
                return this["key"] as string;
            }
            set
            {
                this["key"] = value;
            }
        }

        [ConfigurationProperty("value",
            IsRequired=true)]
        public string Value
        {
            get
            {
                return this["value"] as string;
            }
            set
            {
                this["value"] = value;
            }
        }
    }
    #endregion
}
