namespace Pattern;

public class Singleton
{
  private static Singleton? UniqueInstance { get; set; }

  /*
  *this is a random number generated when instantiating 
  *the class, it is used to prove that the reference to 
  *the object is the same
  */
  public static double RandomNumber { get; set; }

  //a private constructor
  //only singleton can instantiate a singleton
  private Singleton()
  {
    Random rd = new Random();
    RandomNumber = rd.NextDouble();
  }

  //method that controls access to the unique
  //instance of singleton
  public static Singleton GetInstance()
  {
    if( UniqueInstance is null)
    {
      UniqueInstance = new Singleton();
    }

    //return the reference to the object
    return UniqueInstance;

  }
}