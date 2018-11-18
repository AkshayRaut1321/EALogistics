using System;
using System.Reflection;

namespace EA_Logistics_Control.Models
{
    class CUserInfo
    {
        public string LoginId { get; set; }
        public string JPGUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public string LoginPW { get; set; }
        public short GENDER { get; set; }
        public short MaritalStatus { get; set; }
        public DateTime DOB { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string SECQUEST { get; set; }
        public string SECANSWER { get; set; }
        public bool TwoStep { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public short AccessLevel { get; set; }

        internal void ResetObject()
        {
            foreach (PropertyInfo property in this.GetType().GetProperties())
            {
                if (property.PropertyType == typeof(string))
                    property.SetValue(this, "");
                else if (property.PropertyType == typeof(int))
                    property.SetValue(this, 0);
                else if (property.PropertyType == typeof(DateTime))
                    property.SetValue(this, new DateTime());
                else if (property.PropertyType == typeof(bool))
                    property.SetValue(this, false);
                else if (property.PropertyType == typeof(short))
                    property.SetValue(this, Convert.ToInt16(0));
            }
        }
    }
}
