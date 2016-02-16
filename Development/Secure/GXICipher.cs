﻿using System;
using Gurux.DLMS.Enums;
namespace Gurux.DLMS.Secure
{
    internal interface GXICipher
    {
        /// <summary>
        /// Encrypt PDU.
        /// </summary>
        /// <param name="command">Command.</param>
        /// <param name="data">Data to encrypt.</param>
        /// <returns>Encrypted data.</returns>
        byte[] Encrypt(Command command, byte[] data);

        /// <summary>
        /// Decrypt data.
        /// </summary>
        /// <param name="data">Decrypted data.</param>
        void Decrypt(GXByteBuffer data);

        /// <summary>
        /// Reset encrypt settings.
        /// </summary>
        void Reset();

        /// <summary>
        /// Is ciphering used. 
        /// </summary>
        /// <returns></returns> 
        bool IsCiphered();

        /// <summary>
        /// Used security.
        /// </summary>
        Security Security
        {
            get;
            set;
        }

        byte[] SystemTitle
        {
            get;
        }

        UInt32 FrameCounter
        {
            get;
        }

        byte[] AuthenticationKey
        {
            get;
        }

        byte[] BlockCipherKey
        {
            get;
        }
    }
}