//
// NotInterestedMessage.cs
//
// Authors:
//   Alan McGovern alan.mcgovern@gmail.com
//
// Copyright (C) 2006 Alan McGovern
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace OctoTorrent.Client.Messages.Standard
{
    /// <summary>
    /// Represents a "NotInterested" message
    /// </summary>
    public class NotInterestedMessage : PeerMessage
    {
        private const int MessageLength = 1;
        internal const byte MessageId = 3;

        #region Methods
        
        public override int Encode(byte[] buffer, int offset)
        {
			var written = offset;

            written += Write(buffer, written, MessageLength);
            written += Write(buffer, written, MessageId);

            return CheckWritten(written - offset);
        }

        public override void Decode(byte[] buffer, int offset, int length)
        {
            // No decoding needed
        }

        /// <summary>
        /// Returns the length of the message in bytes
        /// </summary>
        public override int ByteLength
        {
            get { return (MessageLength + 4); }
        }

        #endregion

        #region Overridden Methods

        public override string ToString()
        {
            return "NotInterestedMessage";
        }

        public override bool Equals(object obj)
        {
            return obj is NotInterestedMessage;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        #endregion
    }
}