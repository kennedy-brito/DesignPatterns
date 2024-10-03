from patterns.singleton import Singleton
"""
testing the singleton param
"""

sing1 = Singleton()
sing2 = Singleton()
print(f"sing1 is equal to sing2? {sing1 == sing2}")

print(f"random number in sing1: {sing1.rd_number}")
print(f"random number in sing2: {sing2.rd_number}")