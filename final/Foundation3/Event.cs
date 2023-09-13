abstract class Event
{
    protected string _title = "";
    protected string _description = "";
    protected string _date = "";
    protected string _time = "";
    protected Address _address = new Address();

    public abstract void FullDetails();
    public abstract void StandardDetails();
    public abstract void ShortDetails();
    public virtual string getTitle()
    {
        return _title;
    }
    public virtual void setTitle(string title)
    {
        _title = title;
    }
    public virtual string getDescription()
    {
        return _description;
    }
    public virtual void setDescription(string description)
    {
        _description = description;
    }
    public virtual string getDate()
    {
        return _date;
    }
    public virtual void setDate(string date)
    {
        _date = date;
    }
    public virtual string getTime()
    {
        return _time;
    }
    public virtual void setTime(string time)
    {
        _time = time;
    }

}