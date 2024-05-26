class Pen:
  def write(self, str):
    raise NotImplementedError("Subclasses must implement write()")

class PilotPen(Pen):
  def write(self, str):
    print(str)  # Use print instead of cout

class PenAdapter(Pen):
  def __init__(self):
    self.pp = PilotPen()

  def write(self, str):
    self.pp.write(str)

class AssignmentWork:
  def __init__(self):
    self.p = None

  def get_pen(self):
    return self.p

  def set_pen(self, p):
    self.p = p

  def write_assignment(self, str):
    if self.p:
      self.p.write(str)
    else:
      print("No pen assigned!")

def main():
  p = PenAdapter()
  aw = AssignmentWork()
  aw.set_pen(p)
  aw.write_assignment("I Won't.")

if __name__ == "__main__":
  main()
