class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Student> Students { get; set; } = [];

    public override string ToString()
    {
        return $"Group: {Name}, Students: {Students.Count}";
    }
}
