import math
def InputData():
  a = float(input("Enter a: "))
  b = float(input("Enter b: "))
  return a, b

def SolveEqual(a,b):
  if a == 0:
    if b == 0:
      print('Vo so nghiem')
    else:
      print('Vo nghiem')
  else:
    x = -b/a
    print('Nghiem x=%.3lf'%x, end='\n')

def main():
  a,b = InputData()
  SolveEqual(a,b)
if __name__=='__main__':
  main()