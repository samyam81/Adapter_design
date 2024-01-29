package AdapterDesign;
// import PilotPen;
public class School {
    public static void main(String[] args) {
            Pen p= new PenAdapter();
            Assignmentwork aw =new Assignmentwork();
            aw.setP(p);
            aw.writeAssignment("I Won't.");
    }
}
