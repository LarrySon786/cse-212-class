public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public string _type { get; set; }
    public List<Feature> _features { get; set; }



}

public class Feature
{
    private string _place;
    private decimal _magnitude;


    public Feature(string place, decimal mag)
    {
        this._place = place;
        this._magnitude = mag;
    }

    public decimal GetMagnitude()
    {
        return _magnitude;
    }
    public string GetPlace()
    {
        return _place;
    }




}