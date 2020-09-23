using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipocs.objects.Objects
{
  public class IRDetection : BasicObject
  {
    public override byte ObjectTypeId { get { return 15; } }

    public byte diodeOutput { get; set; }

    public byte inputIR { get; set; }

    protected override void Serialize(List<byte> buffer)
    {
      buffer.Add(this.diodeOutput);
      buffer.Add(this.inputIR);
    }
  }
}
