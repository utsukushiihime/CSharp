using System;

namespace ConsoleApp
{
  interface IMobile
  {
    IAndroid GetAndroidPhone();
    IiOS GetiOSPhone();
  }

  class Samsung : IMobile
  {
    public IAndroid GetAndroidPhone()
    {
      return new SamsungGalaxy();
    }

    public IiOS GetiOSPhone()
    {
      return new SamsungGuru();
    }
  }

  interface IAndroid 
  {
  string GetModelDetails();
  }

  interface IiOS
  {
    string GetModelDetails();
  }

  class SamsungGalaxy : IAndroid
  {
    public string GetModelDetails()
    {
      return "Model: Samsung Galaxy - RAM: 2GB - Camera: 13MP";
    }
  }

  class SamsungGuru : IiOS
  {
    public string GetModelDetails()
    {
      return "Model: Samsung Guru - RAM: N/A - Camera: N/A";
    }
  }

  class MobileClient
  {
     IAndroid androidPhone;
     IiOS iOSPhone;
  }
  
  class Example
  {
    public void Main(string[] args)
    {
      
    }
  }
}