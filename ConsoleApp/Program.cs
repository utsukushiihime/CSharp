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
  
  class Example
  {
    public void Main(string[] args)
    {
      
    }
  }
}