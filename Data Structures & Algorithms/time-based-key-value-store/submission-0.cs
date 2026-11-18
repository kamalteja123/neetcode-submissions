public class TimeMap
{
    private Dictionary<string, List<(int time, string value)>> store = new();

    public TimeMap() { }

    public void Set(string key, string value, int timestamp)
    {
        if (!store.TryGetValue(key, out var list))
        {
            list = new List<(int time, string value)>();
            store[key] = list;
        }
        list.Add((timestamp, value));
    }

    public string Get(string key, int timestamp)
    {
        if (!store.TryGetValue(key, out var list))
            return "";

        string result = "";
        int left = 0;
        int right = list.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (list[mid].time <= timestamp)
            {
                result = list[mid].value;   // allowed, remember it
                left = mid + 1;             // look for a later one
            }
            else
            {
                right = mid - 1;            // too late, throw away mid and the right
            }
        }
        return result;
    }
}