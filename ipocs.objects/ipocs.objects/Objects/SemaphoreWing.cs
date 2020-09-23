using System.Collections.Generic;

namespace ipocs.objects.Objects
{
  public class SemaphoreWing : BasicObject
  {
    public override byte ObjectTypeId { get { return 30; } }

    public byte output { get; set; }
    public byte speed { get; set; }

    protected override void Serialize(List<byte> buffer)
    {
      buffer.Add(output);
      buffer.Add(speed);
    }
  }
}
