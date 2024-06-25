namespace Payroll
{
    public interface Employable
    {
        string GetFullName();
        float GetSalary();
        void AddNote(string type, string note);
        string GetNote(string type);
    }
}
