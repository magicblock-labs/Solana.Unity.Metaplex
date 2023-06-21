using Solana.Unity.Programs.Utilities;
using Solana.Unity.Wallet;
using System;

namespace Solana.Unity.Metaplex.CandyGuard.Accounts
{
    public class CandyGuardAccounts
    {
        public partial class FreezeEscrow
        {
            public static ulong ACCOUNT_DISCRIMINATOR => 13295661872568646371UL;
            public static ReadOnlySpan<byte> ACCOUNT_DISCRIMINATOR_BYTES => new byte[] { 227, 186, 40, 152, 7, 174, 131, 184 };
            public static string ACCOUNT_DISCRIMINATOR_B58 => "f6ErkZturrj";
            public PublicKey CandyGuard { get; set; }

            public PublicKey CandyMachine { get; set; }

            public ulong FrozenCount { get; set; }

            public long? FirstMintTime { get; set; }

            public long FreezePeriod { get; set; }

            public PublicKey Destination { get; set; }

            public PublicKey Authority { get; set; }

            public static FreezeEscrow Deserialize(ReadOnlySpan<byte> _data)
            {
                int offset = 0;
                ulong accountHashValue = _data.GetU64(offset);
                offset += 8;
                if (accountHashValue != ACCOUNT_DISCRIMINATOR)
                {
                    return null;
                }

                FreezeEscrow result = new FreezeEscrow();
                result.CandyGuard = _data.GetPubKey(offset);
                offset += 32;
                result.CandyMachine = _data.GetPubKey(offset);
                offset += 32;
                result.FrozenCount = _data.GetU64(offset);
                offset += 8;
                if (_data.GetBool(offset++))
                {
                    result.FirstMintTime = _data.GetS64(offset);
                    offset += 8;
                }

                result.FreezePeriod = _data.GetS64(offset);
                offset += 8;
                result.Destination = _data.GetPubKey(offset);
                offset += 32;
                result.Authority = _data.GetPubKey(offset);
                offset += 32;
                return result;
            }
        }

        public partial class CandyGuard
        {
            public static ulong ACCOUNT_DISCRIMINATOR => 13052108403907219244UL;
            public static ReadOnlySpan<byte> ACCOUNT_DISCRIMINATOR_BYTES => new byte[] { 44, 207, 199, 184, 112, 103, 34, 181 };
            public static string ACCOUNT_DISCRIMINATOR_B58 => "8VjHY4paKeL";
            public PublicKey Base { get; set; }

            public byte Bump { get; set; }

            public PublicKey Authority { get; set; }

            public static CandyGuard Deserialize(ReadOnlySpan<byte> _data)
            {
                int offset = 0;
                ulong accountHashValue = _data.GetU64(offset);
                offset += 8;
                if (accountHashValue != ACCOUNT_DISCRIMINATOR)
                {
                    return null;
                }

                CandyGuard result = new CandyGuard();
                result.Base = _data.GetPubKey(offset);
                offset += 32;
                result.Bump = _data.GetU8(offset);
                offset += 1;
                result.Authority = _data.GetPubKey(offset);
                offset += 32;
                return result;
            }
        }
    }
}
