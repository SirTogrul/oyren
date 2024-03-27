namespace classtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
         User user= new User();        
          user.Username = "test";
        }
    }
}class Human
{
    string Name;
    string Surname;
    private byte _age;
    public byte Age 
    { 
        get 
        {
            return _age;
        } 
        set 
        {
            if(value > 0)
            {
                _age = value;
            }
        } 
    }
}
class User:Human
{
    private string _username;

    public string Username
    {
        get
        {
            return _username;
        }
        set
        {
         if((value.Length > 6) && (value.Length < 25))
            {
               _username = value;
            }
            else
            {
                Console.WriteLine("yeniden username daxil edin");
            }
        }
    }
    private string _password;
    
    public string Pasword
    {
        get
        {
            return _password;
        }
        set 
        {
         if((value.Length >8)&&( value.Length < 25))
            {
                _password = value;
            }
            else
            {
                Console.WriteLine("yeniden password daxil edin");
            }
        }
    }
}