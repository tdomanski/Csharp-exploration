class Rectangle
{
    private float width;
    private float height;
    private float area;
    public Rectangle(float width, float height)
    {
        this.width = width;
        this.height = height;
        this.area = width * height;
    }
    public void setWidth(float width)
    {
        this.width = width;
        updateArea();
    }
    public void setHeight(float height)
    {
        this.height = height;
        updateArea();
    }
    private void updateArea()
    {
        area = width * height;
    }

    public float getArea() => area;
}