public class Solution {
   public int CarFleet(int target, int[] position, int[] speed)
{
    int n = position.Length;

    int[][] cars = new int[n][];
    for (int i = 0; i < n; i++)
        cars[i] = new int[] { position[i], speed[i] };

    Array.Sort(cars, (a, b) => b[0].CompareTo(a[0]));   // nearest the target first

    int fleets = 0;
    double frontTime = 0;

    foreach (int[] car in cars)
    {
        double time = (double)(target - car[0]) / car[1];

        if (frontTime < time)    // arrives later than the front fleet: new fleet
        {
            fleets++;
            frontTime = time;
        }
    }
    return fleets;
}
}
