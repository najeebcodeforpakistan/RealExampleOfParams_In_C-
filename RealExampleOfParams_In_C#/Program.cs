using RealExampleOfParams_In_C_;

public class Program
{
    public static void Main()
    {
        Logger logger = new Logger();

        //Log ction with not details
        logger.LogAction("UserLogin");

        //Log an action with some addtional details
        logger.LogAction("FileUpload","FileName: report.pdf","Size:5MB","Status:Successfully");

        //Log anaction with multiple details
        logger.LogAction("DataProcessing",
            "Records Processed:1000",
            "Errors:None",
            "Duration:5 seconds",
            "Processed By:DataServices"
            );
    }
}
