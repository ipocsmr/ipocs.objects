using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipocs.objects.Objects
{
  public class PointsMotor_Pulse : PointsMotor
  {
    public override byte MotorTypeId { get { return 1; } }
    public byte ThrowLeftOutput { get; set; }
    public byte ThrowRightOutput { get; set; }
    public byte positionPin { get; set; }
    public bool reverseStatus { get; set; }
    public bool lowToThrow { get; set; }
    public byte timeToPulse { get; set; }

    public override List<byte> Serialize()
    {
      var vector = new List<byte>();
      vector.Add(MotorTypeId);
      vector.Add(this.ThrowLeftOutput);
      vector.Add(this.ThrowRightOutput);
      vector.Add(positionPin);
      vector.Add((byte)(reverseStatus ? 1 : 0));
      vector.Add((byte)(lowToThrow ? 1 : 0));
      vector.Add(this.timeToPulse);
      return vector;
    }
  }
}
