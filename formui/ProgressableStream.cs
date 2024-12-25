using System;
using System.IO;

public class ProgressableStream : Stream
{
    private readonly Stream _stream;
    private readonly IProgress<int> _progress;
    private long _totalBytesRead;

    public ProgressableStream(Stream stream, IProgress<int> progress)
    {
        _stream = stream ?? throw new ArgumentNullException(nameof(stream));
        _progress = progress ?? throw new ArgumentNullException(nameof(progress));
        _totalBytesRead = 0;
    }

    public override bool CanRead => _stream.CanRead;
    public override bool CanSeek => _stream.CanSeek;
    public override bool CanWrite => _stream.CanWrite;
    public override long Length => _stream.Length;
    public override long Position
    {
        get => _stream.Position;
        set => _stream.Position = value;
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        int bytesRead = _stream.Read(buffer, offset, count);
        _totalBytesRead += bytesRead;

        // İlerlemeyi hesaplıyoruz ve progress bar'ı güncelliyoruz
        _progress.Report((int)((double)_totalBytesRead / _stream.Length * 100));

        return bytesRead;
    }

    public override void Flush() => _stream.Flush();
    public override long Seek(long offset, SeekOrigin origin) => _stream.Seek(offset, origin);
    public override void SetLength(long value) => _stream.SetLength(value);
    public override void Write(byte[] buffer, int offset, int count) => _stream.Write(buffer, offset, count);
}
