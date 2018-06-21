public struct MapTile
{
    public float Height { get; set; }
    public float Temperature { get; set; }
    public float Moisture { get; set; }
    
    public MapTile(float height, float temp, float moisture)
    {
        Height = height;
        Temperature = temp;
        Moisture = moisture;
    }
}