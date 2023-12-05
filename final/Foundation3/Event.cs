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
    protected virtual void setTitle(string title)
    {
        _title = title;
    }
    protected virtual string getDescription()
    {
        return _description;
    }
    protected virtual void setDescription(string description)
    {
        _description = description;
    }
    protected virtual string getDate()
    {
        return _date;
    }
    protected virtual void setDate(string date)
    {
        _date = date;
    }
    protected virtual string getTime()
    {
        return _time;
    }
    protected virtual void setTime(string time)
    {
        _time = time;
    }

}