namespace Shared
{
    public class SmallResponse
    {
        public string Message { get; set; }

        public static SmallResponse Create()
        {
            return new SmallResponse
            {
                Message = "SmallResponse"
            };
        }
    }
}
