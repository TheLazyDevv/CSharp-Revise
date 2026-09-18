using Loadings_ExplicitLoading_Revise;

class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }

}