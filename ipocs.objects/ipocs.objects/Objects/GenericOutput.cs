using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipocs.objects.Objects
{
  public class GenericOutput : BasicObject
  {
    public override byte ObjectTypeId { get { return 10; } }

    public byte OutputPin { get; set; }

    protected override void Serialize(List<byte> buffer)
    {
      buffer.Add(this.OutputPin);
    }
  }
}
