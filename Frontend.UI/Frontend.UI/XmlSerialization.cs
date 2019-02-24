using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Frontend.UI;

public class XmlSerialization
{
    public static string LoginData (string ccNumber, string pinNumber)
    {
        Objects.CheckCcPinNumber loginData = new Objects.CheckCcPinNumber();
        loginData.CcNumber = ccNumber;
        loginData.PinNumber = pinNumber;
        XmlSerializer x = new XmlSerializer(loginData.GetType());
        using(StringWriter textWriter = new StringWriter())
        {
            x.Serialize(Console.Out, loginData);
            Console.WriteLine();
            Console.ReadLine();
            x.Serialize(textWriter, loginData);
            return textWriter.ToString();
        }

        
    }
}