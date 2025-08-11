class Arrow
{
    enum Arrowhead { steel, wood, obsidian }
    enum Fletching { plastic, turkey, goose }

    public Arrowhead arrowhead;
    public Fletching fletching;
    public float length;

    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        this.arrowhead = arrowhead;
        this.fletching = fletching;
        this.length = length;
    }
    public float getCost()
    {
        float arrowheadCost;
        if (arrowhead = Arrowhead.steel) arrowheadCost = 10;
        else if (arrowhead = Arrowhead.wood) arrowheadCost = 3;
        else if (arrowhead = Arrowhead.obsidian) arrowheadCost = 5;
        float fletchingCost;
        if (fletching = Fletching.plastic) fletchingCost = 10;
        else if (fletching = Fletching.goose) fletchingCost = 3;
        else if (fletching = Fletching.turkey) fletchingCost = 5;

        return arrowheadCost + fletchingCost + (length * 0.05);
    }
    
}