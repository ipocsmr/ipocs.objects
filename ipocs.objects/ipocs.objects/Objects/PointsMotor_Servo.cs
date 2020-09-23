using System.Collections.Generic;

namespace ipocs.objects.Objects
{
  public class PointsMotor_Servo : PointsMotor
  {
    public override byte MotorTypeId { get { return 2; } }
    public byte servoPin { get; set; }
    public byte positionPin { get; set; }
    public bool reverseStatus { get; set; }

    public override List<byte> Serialize()
    {
      var vector = new List<byte>();
      vector.Add(MotorTypeId);
      vector.Add(servoPin);
      vector.Add(positionPin);
      vector.Add((byte)(reverseStatus ? 1 : 0));
      return vector;
    }

  }
}
