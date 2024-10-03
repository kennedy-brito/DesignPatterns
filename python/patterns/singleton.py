from random import Random

class Singleton:

  def __new__(cls):
    
    if not hasattr(cls, "instance"):
      cls.instance = super(Singleton, cls).__new__(cls)
      # a random number to prove that instance
      # is the same for all classes
      rd = Random()
      cls.rd_number = rd.random() * 1000

    
    return cls.instance
  
  