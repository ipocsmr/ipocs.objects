using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipocs.objects.Objects
{
  public class LevelCrossing : BasicObject
  {
    public override byte ObjectTypeId { get { return 20; } }

    public byte LightWhite { get; set; }
    public byte LightRed { get; set; }
    public byte Sound { get; set; }
    public byte TrainDetection { get; set; }
    public byte Barrier1 { get; set; }
    public byte Barrier2 { get; set; }
    public byte Barrier3 { get; set; }
    public byte Barrier4 { get; set; }

    protected override void Serialize(List<byte> buffer)
    {
      buffer.Add(this.LightWhite);
      buffer.Add(this.LightRed);
      buffer.Add(this.Sound);
      buffer.Add(this.TrainDetection);
      buffer.Add(this.Barrier1);
      buffer.Add(this.Barrier2);
      buffer.Add(this.Barrier3);
      buffer.Add(this.Barrier4);
    }
  }
}
