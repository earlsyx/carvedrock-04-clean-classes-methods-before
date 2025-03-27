
namespace carvedrock.bl.CleanClassesAndMethods.FavoringReadability.FavorReadability
{
    public class FavorReadability
    {

        public string RateTrail(decimal length, decimal elevation, string traffic, string type)
        {
            if (length < 0) throw new Exception("length cannot be null");
            if (elevation < 0) throw new Exception("elevation cannot be null");
            if (traffic == null) throw new Exception("traffic cannot be null");
            if (type == null) throw new Exception("type cannot be null");
            if (length > 20 || elevation > 400) return "hard";
            else if
                (length > 10 || elevation > 100) return traffic == "heavy" ? "hard" : "moderate";
            else
                return "easy";
            
        }

    }
}
