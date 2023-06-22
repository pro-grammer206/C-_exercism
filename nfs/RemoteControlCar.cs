namespace nfs;
class RemoteControlCar{
    private int speed;
    private int batteryDrain;
    private int distanceCovered;
    private int batteryLeft ;

    public static RemoteControlCar Nitro(){
        return new RemoteControlCar(50,4);
    }
    public RemoteControlCar(int speed,int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.distanceCovered = 0;
        this.batteryLeft = 100;
    }
    public void Drive(){
        if(BatteryDrained()){
            return;
        }
        this.distanceCovered+=this.speed;
        this.batteryLeft-=this.batteryDrain;
    }
    public int DistanceDriven(){
        return this.distanceCovered;
    }
    public bool BatteryDrained(){
        return this.batteryDrain>this.batteryLeft?true:false;
    }
}