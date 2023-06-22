namespace nfs;

class RaceTrack{
    private int distance;

    public RaceTrack(int distance){
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar rc){
        while(!rc.BatteryDrained() && rc.DistanceDriven()<this.distance){
            rc.Drive();
        }
        return rc.DistanceDriven()>=this.distance?true:false;
    }
}