namespace hot;

class Telemetry{
    public static byte[] ToBuffer(long reading){

       byte[] byteArray = BitConverter.GetBytes(reading);
            return byteArray;
    }
}