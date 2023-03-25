using Solana.Unity.Metaplex.Candymachine.Core.Types;
using Solana.Unity.Programs.Utilities;
using Solana.Unity.Wallet;
using System;
using System.Collections.Generic;
#pragma warning disable CS1591
namespace Solana.Unity.Metaplex.Candymachine.Core
{

    public static class CMCoreProgram
    {
        public static Solana.Unity.Rpc.Models.TransactionInstruction AddConfigLines(AddConfigLinesAccounts accounts, uint index, ConfigLine[] configLines, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(7670484038798291679UL, offset);
            offset += 8;
            _data.WriteU32(index, offset);
            offset += 4;
            _data.WriteS32(configLines.Length, offset);
            offset += 4;
            foreach (var configLinesElement in configLines)
            {
                offset += configLinesElement.Serialize(_data, offset);
            }

            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction Initialize(InitializeAccounts accounts, CandyMachineData data, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.AuthorityPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionUpdateAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionAuthorityRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(17121445590508351407UL, offset);
            offset += 8;
            offset += data.Serialize(_data, offset);
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction Mint(MintAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.AuthorityPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.MintAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NftMintAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionAuthorityRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionUpdateAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.RecentSlothashes, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(12000283993290389811UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction SetAuthority(SetAuthorityAccounts accounts, PublicKey newAuthority, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(8726466921180297861UL, offset);
            offset += 8;
            _data.WritePubKey(newAuthority, offset);
            offset += 32;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction SetCollection(SetCoreCollectionAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.AuthorityPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionAuthorityRecord, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NewCollectionUpdateAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NewCollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NewCollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NewCollectionMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NewCollectionAuthorityRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(16085651328043253440UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction SetMintAuthority(SetMintAuthorityAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.MintAuthority, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(8748152548857970499UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction Update(UpdateAccounts accounts, CandyMachineData data, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(9222597562720635099UL, offset);
            offset += 8;
            offset += data.Serialize(_data, offset);
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction Withdraw(WithdrawAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Authority, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(2495396153584390839UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }
    }
}