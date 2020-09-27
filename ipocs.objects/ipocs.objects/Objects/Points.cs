using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipocs.objects.Objects
{
  public class Points : BasicObject
  {
    public override byte ObjectTypeId { get { return 1; } }

    public byte FrogOutput { get; set; }

    public ObservableCollection<PointsMotor> Motors { get; } = new ObservableCollection<PointsMotor>();

    protected override void Serialize(List<byte> buffer)
    {
      buffer.Add(this.FrogOutput);
      foreach (var motor in Motors)
      {
        var motorVector = motor.Serialize();
        buffer.AddRange(motorVector);
      }
    }
  }
}
