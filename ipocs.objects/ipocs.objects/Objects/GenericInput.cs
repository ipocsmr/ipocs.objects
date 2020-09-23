using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipocs.objects.Objects
{
  public class GenericInput : BasicObject
  {
    public override byte ObjectTypeId { get { return 11; } }

    public byte InputPin { get; set; }

    public byte DebounceTime { get; set; }

    public byte ReleaseHoldTime { get; set; }

    protected override void Serialize(List<byte> buffer)
    {
      buffer.Add(this.InputPin);
      buffer.Add(this.DebounceTime);
      buffer.Add(this.ReleaseHoldTime);
    }
  }
}
