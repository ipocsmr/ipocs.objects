using System.Collections.Generic;

namespace ipocs.objects.Objects
{
  public class Turntable : BasicObject
  {
    public override byte ObjectTypeId { get { return 40; } }

    public byte numPositions { get; set; }
    public byte resetPositionInput { get; set; }
    public byte trackDetectionInput { get; set; }
    public byte clockwiseOutput { get; set; }
    public byte counterClockwiseOutput { get; set; }

    protected override void Serialize(List<byte> buffer)
    {
      buffer.Add(numPositions);
      buffer.Add(resetPositionInput);
      buffer.Add(trackDetectionInput);
      buffer.Add(clockwiseOutput);
      buffer.Add(counterClockwiseOutput);
    }
  }
}
