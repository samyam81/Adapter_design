class PenAdapter : Pen {
    private val pilotPen = PilotPen()

    override fun write(str: String) {
        pilotPen.mark(str)
    }
}
