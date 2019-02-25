using System.Xml.Serialization;

namespace Frontend.UI
{
    public class Objects
    {
        [XmlRootAttribute("LoginData", IsNullable = false)]
        public class CheckCcPinNumber
        {
            public string CcNumber { get; set; }
            public string PinNumber { get; set; }
        }
        [XmlRootAttribute("BalanceData", IsNullable = false)]
        public class CheckBalance
        {
            public string AccountNumber { get; set; }
        }
    }
}
