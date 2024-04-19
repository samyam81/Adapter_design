#include <iostream>
using namespace std;

// Pen interface
class Pen {
public:
    virtual void write(string str) = 0;
};

// PilotPen class
class PilotPen {
public:
    void mark(string str) {
        cout << str << endl;
    }
};

// PenAdapter class
class PenAdapter : public Pen {
private:
    PilotPen pp;
public:
    void write(string str) override {
        pp.mark(str);
    }
};

// AssignmentWork class
class AssignmentWork {
private:
    Pen* p;
public:
    Pen* getP() {
        return p;
    }
    
    void setP(Pen* p) {
        this->p = p;
    }
    
    void writeAssignment(string str) {
        p->write(str);
    }
};

// School class
int main() {
    PenAdapter p;
    AssignmentWork aw;
    aw.setP(&p);
    aw.writeAssignment("I Won't.");
    return 0;
}
