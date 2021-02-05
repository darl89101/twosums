namespace TwoSums
{
    public interface ITwoSumService
    {
        IndicesModel FindIndicesByArrayAndObjetive(IFixedArray fixedArray, int objetive);
    }

    public interface IFixedArray
    {
        int[] GetArray();
    }

    public class IndicesModel
    {
        public int Indice1 { get; set; }
        public int Indice2 { get; set; }
    }

    public class TwoSumService : ITwoSumService
    {
        public IndicesModel FindIndicesByArrayAndObjetive(IFixedArray fixedArray, int objetive)
        {
            var array = fixedArray.GetArray();

            for (int i = 0; i < array.Length; i++)
            {
                var item1 = array[i];

                for (int j = 0; j < array.Length; j++)
                {
                    var item2 = array[j];

                    if (i != j && item1 + item2 == objetive)
                        return new IndicesModel { Indice1 = i, Indice2 = j };
                }
            }

            return null;
        }
    }
}
