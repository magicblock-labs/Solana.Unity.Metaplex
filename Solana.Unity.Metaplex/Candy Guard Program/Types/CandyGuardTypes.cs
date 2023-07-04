using Solana.Unity.Programs.Utilities;
using Solana.Unity.Wallet;
using System;
using System.Text;

namespace Solana.Unity.Metaplex.CandyGuard
{
    public partial class AddressGate
    {
        public PublicKey Address { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WritePubKey(Address, offset);
            offset += 32;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out AddressGate result)
        {
            int offset = initialOffset;
            result = new AddressGate();
            result.Address = _data.GetPubKey(offset);
            offset += 32;
            return offset - initialOffset;
        }
    }

    public partial class Allocation
    {
        public byte Id { get; set; }

        public uint Limit { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteU8(Id, offset);
            offset += 1;
            _data.WriteU32(Limit, offset);
            offset += 4;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out Allocation result)
        {
            int offset = initialOffset;
            result = new Allocation();
            result.Id = _data.GetU8(offset);
            offset += 1;
            result.Limit = _data.GetU32(offset);
            offset += 4;
            return offset - initialOffset;
        }
    }

    public partial class AllowList
    {
        public byte[] MerkleRoot { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteSpan(MerkleRoot, offset);
            offset += MerkleRoot.Length;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out AllowList result)
        {
            int offset = initialOffset;
            result = new AllowList();
            result.MerkleRoot = _data.GetBytes(offset, 32);
            offset += 32;
            return offset - initialOffset;
        }
    }

    public partial class BotTax
    {
        public ulong Lamports { get; set; }

        public bool LastInstruction { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteU64(Lamports, offset);
            offset += 8;
            _data.WriteBool(LastInstruction, offset);
            offset += 1;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out BotTax result)
        {
            int offset = initialOffset;
            result = new BotTax();
            result.Lamports = _data.GetU64(offset);
            offset += 8;
            result.LastInstruction = _data.GetBool(offset);
            offset += 1;
            return offset - initialOffset;
        }
    }

    public partial class EndDate
    {
        public long Date { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteS64(Date, offset);
            offset += 8;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out EndDate result)
        {
            int offset = initialOffset;
            result = new EndDate();
            result.Date = _data.GetS64(offset);
            offset += 8;
            return offset - initialOffset;
        }
    }

    public partial class FreezeSolPayment
    {
        public ulong Lamports { get; set; }

        public PublicKey Destination { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteU64(Lamports, offset);
            offset += 8;
            _data.WritePubKey(Destination, offset);
            offset += 32;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out FreezeSolPayment result)
        {
            int offset = initialOffset;
            result = new FreezeSolPayment();
            result.Lamports = _data.GetU64(offset);
            offset += 8;
            result.Destination = _data.GetPubKey(offset);
            offset += 32;
            return offset - initialOffset;
        }
    }

    public partial class FreezeTokenPayment
    {
        public ulong Amount { get; set; }

        public PublicKey Mint { get; set; }

        public PublicKey DestinationAta { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteU64(Amount, offset);
            offset += 8;
            _data.WritePubKey(Mint, offset);
            offset += 32;
            _data.WritePubKey(DestinationAta, offset);
            offset += 32;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out FreezeTokenPayment result)
        {
            int offset = initialOffset;
            result = new FreezeTokenPayment();
            result.Amount = _data.GetU64(offset);
            offset += 8;
            result.Mint = _data.GetPubKey(offset);
            offset += 32;
            result.DestinationAta = _data.GetPubKey(offset);
            offset += 32;
            return offset - initialOffset;
        }
    }

    public partial class Gatekeeper
    {
        public PublicKey GatekeeperNetwork { get; set; }

        public bool ExpireOnUse { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WritePubKey(GatekeeperNetwork, offset);
            offset += 32;
            _data.WriteBool(ExpireOnUse, offset);
            offset += 1;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out Gatekeeper result)
        {
            int offset = initialOffset;
            result = new Gatekeeper();
            result.GatekeeperNetwork = _data.GetPubKey(offset);
            offset += 32;
            result.ExpireOnUse = _data.GetBool(offset);
            offset += 1;
            return offset - initialOffset;
        }
    }

    public partial class MintLimit
    {
        public byte Id { get; set; }

        public ushort Limit { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteU8(Id, offset);
            offset += 1;
            _data.WriteU16(Limit, offset);
            offset += 2;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out MintLimit result)
        {
            int offset = initialOffset;
            result = new MintLimit();
            result.Id = _data.GetU8(offset);
            offset += 1;
            result.Limit = _data.GetU16(offset);
            offset += 2;
            return offset - initialOffset;
        }
    }

    public partial class NftBurn
    {
        public PublicKey RequiredCollection { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WritePubKey(RequiredCollection, offset);
            offset += 32;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out NftBurn result)
        {
            int offset = initialOffset;
            result = new NftBurn();
            result.RequiredCollection = _data.GetPubKey(offset);
            offset += 32;
            return offset - initialOffset;
        }
    }

    public partial class NftGate
    {
        public PublicKey RequiredCollection { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WritePubKey(RequiredCollection, offset);
            offset += 32;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out NftGate result)
        {
            int offset = initialOffset;
            result = new NftGate();
            result.RequiredCollection = _data.GetPubKey(offset);
            offset += 32;
            return offset - initialOffset;
        }
    }

    public partial class NftPayment
    {
        public PublicKey RequiredCollection { get; set; }

        public PublicKey Destination { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WritePubKey(RequiredCollection, offset);
            offset += 32;
            _data.WritePubKey(Destination, offset);
            offset += 32;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out NftPayment result)
        {
            int offset = initialOffset;
            result = new NftPayment();
            result.RequiredCollection = _data.GetPubKey(offset);
            offset += 32;
            result.Destination = _data.GetPubKey(offset);
            offset += 32;
            return offset - initialOffset;
        }
    }

    public partial class ProgramGate
    {
        public PublicKey[] Additional { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteS32(Additional.Length, offset);
            offset += 4;
            foreach (var additionalElement in Additional)
            {
                _data.WritePubKey(additionalElement, offset);
                offset += 32;
            }

            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out ProgramGate result)
        {
            int offset = initialOffset;
            result = new ProgramGate();
            int resultAdditionalLength = (int)_data.GetU32(offset);
            offset += 4;
            result.Additional = new PublicKey[resultAdditionalLength];
            for (uint resultAdditionalIdx = 0; resultAdditionalIdx < resultAdditionalLength; resultAdditionalIdx++)
            {
                result.Additional[resultAdditionalIdx] = _data.GetPubKey(offset);
                offset += 32;
            }

            return offset - initialOffset;
        }
    }

    public partial class RedeemedAmount
    {
        public ulong Maximum { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteU64(Maximum, offset);
            offset += 8;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out RedeemedAmount result)
        {
            int offset = initialOffset;
            result = new RedeemedAmount();
            result.Maximum = _data.GetU64(offset);
            offset += 8;
            return offset - initialOffset;
        }
    }

    public partial class SolPayment
    {
        public ulong Lamports { get; set; }

        public PublicKey Destination { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteU64(Lamports, offset);
            offset += 8;
            _data.WritePubKey(Destination, offset);
            offset += 32;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out SolPayment result)
        {
            int offset = initialOffset;
            result = new SolPayment();
            result.Lamports = _data.GetU64(offset);
            offset += 8;
            result.Destination = _data.GetPubKey(offset);
            offset += 32;
            return offset - initialOffset;
        }
    }

    public partial class StartDate
    {
        public long Date { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteS64(Date, offset);
            offset += 8;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out StartDate result)
        {
            int offset = initialOffset;
            result = new StartDate();
            result.Date = _data.GetS64(offset);
            offset += 8;
            return offset - initialOffset;
        }
    }

    public partial class ThirdPartySigner
    {
        public PublicKey SignerKey { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WritePubKey(SignerKey, offset);
            offset += 32;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out ThirdPartySigner result)
        {
            int offset = initialOffset;
            result = new ThirdPartySigner();
            result.SignerKey = _data.GetPubKey(offset);
            offset += 32;
            return offset - initialOffset;
        }
    }

    public partial class Token2022Payment
    {
        public ulong Amount { get; set; }

        public PublicKey Mint { get; set; }

        public PublicKey DestinationAta { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteU64(Amount, offset);
            offset += 8;
            _data.WritePubKey(Mint, offset);
            offset += 32;
            _data.WritePubKey(DestinationAta, offset);
            offset += 32;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out Token2022Payment result)
        {
            int offset = initialOffset;
            result = new Token2022Payment();
            result.Amount = _data.GetU64(offset);
            offset += 8;
            result.Mint = _data.GetPubKey(offset);
            offset += 32;
            result.DestinationAta = _data.GetPubKey(offset);
            offset += 32;
            return offset - initialOffset;
        }
    }

    public partial class TokenBurn
    {
        public ulong Amount { get; set; }

        public PublicKey Mint { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteU64(Amount, offset);
            offset += 8;
            _data.WritePubKey(Mint, offset);
            offset += 32;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out TokenBurn result)
        {
            int offset = initialOffset;
            result = new TokenBurn();
            result.Amount = _data.GetU64(offset);
            offset += 8;
            result.Mint = _data.GetPubKey(offset);
            offset += 32;
            return offset - initialOffset;
        }
    }

    public partial class TokenGate
    {
        public ulong Amount { get; set; }

        public PublicKey Mint { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteU64(Amount, offset);
            offset += 8;
            _data.WritePubKey(Mint, offset);
            offset += 32;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out TokenGate result)
        {
            int offset = initialOffset;
            result = new TokenGate();
            result.Amount = _data.GetU64(offset);
            offset += 8;
            result.Mint = _data.GetPubKey(offset);
            offset += 32;
            return offset - initialOffset;
        }
    }

    public partial class TokenPayment
    {
        public ulong Amount { get; set; }

        public PublicKey Mint { get; set; }

        public PublicKey DestinationAta { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteU64(Amount, offset);
            offset += 8;
            _data.WritePubKey(Mint, offset);
            offset += 32;
            _data.WritePubKey(DestinationAta, offset);
            offset += 32;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out TokenPayment result)
        {
            int offset = initialOffset;
            result = new TokenPayment();
            result.Amount = _data.GetU64(offset);
            offset += 8;
            result.Mint = _data.GetPubKey(offset);
            offset += 32;
            result.DestinationAta = _data.GetPubKey(offset);
            offset += 32;
            return offset - initialOffset;
        }
    }

    public partial class RouteArgs
    {
        public GuardType Guard { get; set; }

        public byte[] Data { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            _data.WriteU8((byte)Guard, offset);
            offset += 1;
            _data.WriteS32(Data.Length, offset);
            offset += 4;
            _data.WriteSpan(Data, offset);
            offset += Data.Length;
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out RouteArgs result)
        {
            int offset = initialOffset;
            result = new RouteArgs();
            result.Guard = (GuardType)_data.GetU8(offset);
            offset += 1;
            int resultDataLength = (int)_data.GetU32(offset);
            offset += 4;
            result.Data = _data.GetBytes(offset, resultDataLength);
            offset += resultDataLength;
            return offset - initialOffset;
        }
    }

    public partial class Group
    {
        public string Label { get; set; }

        public GuardSet Guards { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            int offset = initialOffset;
            offset += _data.WriteBorshString(Label, offset);
            offset += Guards.Serialize(_data, offset);
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out Group result)
        {
            int offset = initialOffset;
            result = new Group();
            offset += _data.GetBorshString(offset, out var resultLabel);
            result.Label = resultLabel;
            offset += GuardSet.Deserialize(_data, offset, out var resultGuards);
            result.Guards = resultGuards;
            return offset - initialOffset;
        }
    }

    /// <summary>
    /// WARNING: This class has an edited Serializer from the IDL due to additional flags being
    /// required in the serialized form.
    /// </summary>
    public partial class GuardSet
    {

        private static int GUARD_COUNT = 21;

        public BotTax BotTax { get; set; }

        public SolPayment SolPayment { get; set; }

        public TokenPayment TokenPayment { get; set; }

        public StartDate StartDate { get; set; }

        public ThirdPartySigner ThirdPartySigner { get; set; }

        public TokenGate TokenGate { get; set; }

        public Gatekeeper Gatekeeper { get; set; }

        public EndDate EndDate { get; set; }

        public AllowList AllowList { get; set; }

        public MintLimit MintLimit { get; set; }

        public NftPayment NftPayment { get; set; }

        public RedeemedAmount RedeemedAmount { get; set; }

        public AddressGate AddressGate { get; set; }

        public NftGate NftGate { get; set; }

        public NftBurn NftBurn { get; set; }

        public TokenBurn TokenBurn { get; set; }

        public FreezeSolPayment FreezeSolPayment { get; set; }

        public FreezeTokenPayment FreezeTokenPayment { get; set; }

        public ProgramGate ProgramGate { get; set; }

        public Allocation Allocation { get; set; }

        public Token2022Payment Token2022Payment { get; set; }

        public int Serialize(byte[] _data, int initialOffset)
        {
            // Keep space open for feature flags.
            int offset = initialOffset + 8;
            int features = 0;
            int index = 0;
            if (BotTax != null)
            {
                offset += BotTax.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (SolPayment != null)
            {
                offset += SolPayment.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (TokenPayment != null)
            {
                offset += TokenPayment.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (StartDate != null)
            {
                offset += StartDate.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (ThirdPartySigner != null)
            {
                offset += ThirdPartySigner.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (TokenGate != null)
            {
                offset += TokenGate.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (Gatekeeper != null)
            {
                offset += Gatekeeper.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (EndDate != null)
            {
                offset += EndDate.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (AllowList != null)
            {
                offset += AllowList.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (MintLimit != null)
            {
                offset += MintLimit.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (NftPayment != null)
            {
                offset += NftPayment.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (RedeemedAmount != null)
            {
                offset += RedeemedAmount.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (AddressGate != null)
            {
                offset += AddressGate.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (NftGate != null)
            {
                offset += NftGate.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (NftBurn != null)
            {
                offset += NftBurn.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (TokenBurn != null)
            {
                offset += TokenBurn.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (FreezeSolPayment != null)
            {
                offset += FreezeSolPayment.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (FreezeTokenPayment != null)
            {
                offset += FreezeTokenPayment.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (ProgramGate != null)
            {
                offset += ProgramGate.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (Allocation != null)
            {
                offset += Allocation.Serialize(_data, offset);
                features |= 1 << index;
            }
            index++;

            if (Token2022Payment != null)
            {
                offset += Token2022Payment.Serialize(_data, offset);
                features |= 1 << index;
            }

            // Write feature flags.
            _data.WriteU64((ulong)features, initialOffset);
            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out GuardSet result)
        {
            int offset = initialOffset;
            result = new GuardSet();
            // Get feature flags
            var featureFlags = (int)_data.GetU64(offset);
            offset += 8;

            // Find enabled guards.
            var guards = new bool[GUARD_COUNT];
            for (int i = 0; i < GUARD_COUNT; i++)
            {
                guards[i] = Convert.ToBoolean((1 << i) & featureFlags);
            }

            if (guards[(int)GuardType.BotTax])
            {
                offset += BotTax.Deserialize(_data, offset, out var botTax);
                result.BotTax = botTax;
            }

            if (guards[(int)GuardType.SolPayment])
            {
                offset += SolPayment.Deserialize(_data, offset, out var solPayment);
                result.SolPayment = solPayment;
            }

            if (guards[(int)GuardType.TokenPayment])
            {
                offset += TokenPayment.Deserialize(_data, offset, out var tokenPayment);
                result.TokenPayment = tokenPayment;
            }

            if (guards[(int)GuardType.StartDate])
            {
                offset += StartDate.Deserialize(_data, offset, out var startDate);
                result.StartDate = startDate;
            }

            if (guards[(int)GuardType.ThirdPartySigner])
            {
                offset += ThirdPartySigner.Deserialize(_data, offset, out var thirdPartySigner);
                result.ThirdPartySigner = thirdPartySigner;
            }

            if (guards[(int)GuardType.TokenGate])
            {
                offset += TokenGate.Deserialize(_data, offset, out var tokenGate);
                result.TokenGate = tokenGate;
            }

            if (guards[(int)GuardType.Gatekeeper])
            {
                offset += Gatekeeper.Deserialize(_data, offset, out var gatekeeper);
                result.Gatekeeper = gatekeeper;
            }

            if (guards[(int)GuardType.EndDate])
            {
                offset += EndDate.Deserialize(_data, offset, out var endDate);
                result.EndDate = endDate;
            }

            if (guards[(int)GuardType.AllowList])
            {
                offset += AllowList.Deserialize(_data, offset, out var allowList);
                result.AllowList = allowList;
            }

            if (guards[(int)GuardType.MintLimit])
            {
                offset += MintLimit.Deserialize(_data, offset, out var mintLimit);
                result.MintLimit = mintLimit;
            }

            if (guards[(int)GuardType.NftPayment])
            {
                offset += NftPayment.Deserialize(_data, offset, out var nftPayment);
                result.NftPayment = nftPayment;
            }

            if (guards[(int)GuardType.RedeemedAmount])
            {
                offset += RedeemedAmount.Deserialize(_data, offset, out var redeemedAmount);
                result.RedeemedAmount = redeemedAmount;
            }

            if (guards[(int)GuardType.AddressGate])
            {
                offset += AddressGate.Deserialize(_data, offset, out var addressGate);
                result.AddressGate = addressGate;
            }

            if (guards[(int)GuardType.NftGate])
            {
                offset += NftGate.Deserialize(_data, offset, out var nftGate);
                result.NftGate = nftGate;
            }

            if (guards[(int)GuardType.NftBurn])
            {
                offset += NftBurn.Deserialize(_data, offset, out var nftBurn);
                result.NftBurn = nftBurn;
            }

            if (guards[(int)GuardType.TokenBurn])
            {
                offset += TokenBurn.Deserialize(_data, offset, out var tokenBurn);
                result.TokenBurn = tokenBurn;
            }

            if (guards[(int)GuardType.FreezeSolPayment])
            {
                offset += FreezeSolPayment.Deserialize(_data, offset, out var freezeSol);
                result.FreezeSolPayment = freezeSol;
            }

            if (guards[(int)GuardType.FreezeTokenPayment])
            {
                offset += FreezeTokenPayment.Deserialize(_data, offset, out var freezeToken);
                result.FreezeTokenPayment = freezeToken;
            }

            if (guards[(int)GuardType.ProgramGate])
            {
                offset += ProgramGate.Deserialize(_data, offset, out var programGate);
                result.ProgramGate = programGate;
            }

            if (guards[(int)GuardType.Allocation])
            {
                offset += Allocation.Deserialize(_data, offset, out var allocation);
                result.Allocation = allocation;
            }

            if (guards[(int)GuardType.Token2022Payment])
            {
                offset += Token2022Payment.Deserialize(_data, offset, out var token2022);
                result.Token2022Payment = token2022;
            }

            return offset - initialOffset;
        }
    }

    public enum GuardType : byte
    {
        BotTax,
        SolPayment,
        TokenPayment,
        StartDate,
        ThirdPartySigner,
        TokenGate,
        Gatekeeper,
        EndDate,
        AllowList,
        MintLimit,
        NftPayment,
        RedeemedAmount,
        AddressGate,
        NftGate,
        NftBurn,
        TokenBurn,
        FreezeSolPayment,
        FreezeTokenPayment,
        ProgramGate,
        Allocation,
        Token2022Payment
    }
}

