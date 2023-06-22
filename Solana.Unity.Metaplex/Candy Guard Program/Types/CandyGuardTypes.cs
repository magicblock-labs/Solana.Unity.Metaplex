using Solana.Unity.Programs.Utilities;
using Solana.Unity.Wallet;
using System;

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

    public partial class GuardSet
    {
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
            int offset = initialOffset;
            if (BotTax != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += BotTax.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (SolPayment != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += SolPayment.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (TokenPayment != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += TokenPayment.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (StartDate != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += StartDate.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (ThirdPartySigner != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += ThirdPartySigner.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (TokenGate != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += TokenGate.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (Gatekeeper != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += Gatekeeper.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (EndDate != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += EndDate.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (AllowList != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += AllowList.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (MintLimit != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += MintLimit.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (NftPayment != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += NftPayment.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (RedeemedAmount != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += RedeemedAmount.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (AddressGate != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += AddressGate.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (NftGate != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += NftGate.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (NftBurn != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += NftBurn.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (TokenBurn != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += TokenBurn.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (FreezeSolPayment != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += FreezeSolPayment.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (FreezeTokenPayment != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += FreezeTokenPayment.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (ProgramGate != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += ProgramGate.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (Allocation != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += Allocation.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            if (Token2022Payment != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += Token2022Payment.Serialize(_data, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            return offset - initialOffset;
        }

        public static int Deserialize(ReadOnlySpan<byte> _data, int initialOffset, out GuardSet result)
        {
            int offset = initialOffset;
            result = new GuardSet();
            if (_data.GetBool(offset++))
            {
                offset += BotTax.Deserialize(_data, offset, out var resultBotTax);
                result.BotTax = resultBotTax;
            }

            if (_data.GetBool(offset++))
            {
                offset += SolPayment.Deserialize(_data, offset, out var resultSolPayment);
                result.SolPayment = resultSolPayment;
            }

            if (_data.GetBool(offset++))
            {
                offset += TokenPayment.Deserialize(_data, offset, out var resultTokenPayment);
                result.TokenPayment = resultTokenPayment;
            }

            if (_data.GetBool(offset++))
            {
                offset += StartDate.Deserialize(_data, offset, out var resultStartDate);
                result.StartDate = resultStartDate;
            }

            if (_data.GetBool(offset++))
            {
                offset += ThirdPartySigner.Deserialize(_data, offset, out var resultThirdPartySigner);
                result.ThirdPartySigner = resultThirdPartySigner;
            }

            if (_data.GetBool(offset++))
            {
                offset += TokenGate.Deserialize(_data, offset, out var resultTokenGate);
                result.TokenGate = resultTokenGate;
            }

            if (_data.GetBool(offset++))
            {
                offset += Gatekeeper.Deserialize(_data, offset, out var resultGatekeeper);
                result.Gatekeeper = resultGatekeeper;
            }

            if (_data.GetBool(offset++))
            {
                offset += EndDate.Deserialize(_data, offset, out var resultEndDate);
                result.EndDate = resultEndDate;
            }

            if (_data.GetBool(offset++))
            {
                offset += AllowList.Deserialize(_data, offset, out var resultAllowList);
                result.AllowList = resultAllowList;
            }

            if (_data.GetBool(offset++))
            {
                offset += MintLimit.Deserialize(_data, offset, out var resultMintLimit);
                result.MintLimit = resultMintLimit;
            }

            if (_data.GetBool(offset++))
            {
                offset += NftPayment.Deserialize(_data, offset, out var resultNftPayment);
                result.NftPayment = resultNftPayment;
            }

            if (_data.GetBool(offset++))
            {
                offset += RedeemedAmount.Deserialize(_data, offset, out var resultRedeemedAmount);
                result.RedeemedAmount = resultRedeemedAmount;
            }

            if (_data.GetBool(offset++))
            {
                offset += AddressGate.Deserialize(_data, offset, out var resultAddressGate);
                result.AddressGate = resultAddressGate;
            }

            if (_data.GetBool(offset++))
            {
                offset += NftGate.Deserialize(_data, offset, out var resultNftGate);
                result.NftGate = resultNftGate;
            }

            if (_data.GetBool(offset++))
            {
                offset += NftBurn.Deserialize(_data, offset, out var resultNftBurn);
                result.NftBurn = resultNftBurn;
            }

            if (_data.GetBool(offset++))
            {
                offset += TokenBurn.Deserialize(_data, offset, out var resultTokenBurn);
                result.TokenBurn = resultTokenBurn;
            }

            if (_data.GetBool(offset++))
            {
                offset += FreezeSolPayment.Deserialize(_data, offset, out var resultFreezeSolPayment);
                result.FreezeSolPayment = resultFreezeSolPayment;
            }

            if (_data.GetBool(offset++))
            {
                offset += FreezeTokenPayment.Deserialize(_data, offset, out var resultFreezeTokenPayment);
                result.FreezeTokenPayment = resultFreezeTokenPayment;
            }

            if (_data.GetBool(offset++))
            {
                offset += ProgramGate.Deserialize(_data, offset, out var resultProgramGate);
                result.ProgramGate = resultProgramGate;
            }

            if (_data.GetBool(offset++))
            {
                offset += Allocation.Deserialize(_data, offset, out var resultAllocation);
                result.Allocation = resultAllocation;
            }

            if (_data.GetBool(offset++))
            {
                offset += Token2022Payment.Deserialize(_data, offset, out var resultToken2022Payment);
                result.Token2022Payment = resultToken2022Payment;
            }

            return offset - initialOffset;
        }
    }

    public partial class GuardData { 
        
        public GuardSet Default { get; set; }

        public Group[] Groups { get; set; }
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

