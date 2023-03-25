using Solana.Unity.Metaplex.Bubblegum.Types;
using Solana.Unity.Programs.Utilities;
using Solana.Unity.Wallet;
using System;
using System.Collections.Generic;
#pragma warning disable CS1591
namespace Solana.Unity.Metaplex.Bubblegum
{

    public static class BubblegumProgram
        {
            public static Solana.Unity.Rpc.Models.TransactionInstruction CreateTree(CreateTreeAccounts accounts, uint maxDepth, uint maxBufferSize, bool? _public, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeCreator, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(15866122498241745829UL, offset);
                offset += 8;
                _data.WriteU32(maxDepth, offset);
                offset += 4;
                _data.WriteU32(maxBufferSize, offset);
                offset += 4;
                if (_public != null)
                {
                    _data.WriteU8(1, offset);
                    offset += 1;
                    _data.WriteBool(_public.Value, offset);
                    offset += 1;
                }
                else
                {
                    _data.WriteU8(0, offset);
                    offset += 1;
                }

                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction SetTreeDelegate(SetTreeDelegateAccounts accounts, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeCreator, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NewTreeDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(7393276431020750589UL, offset);
                offset += 8;
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction MintV1(MintV1Accounts accounts, MetadataArgs message, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafOwner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeDelegate, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(7527366247671947921UL, offset);
                offset += 8;
                offset += message.Serialize(_data, offset);
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction MintToCollectionV1(MintToCollectionV1Accounts accounts, MetadataArgs metadataArgs, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafOwner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeDelegate, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionAuthorityRecordPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.EditionAccount, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.BubblegumSigner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(1105245328311980697UL, offset);
                offset += 8;
                offset += metadataArgs.Serialize(_data, offset);
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction VerifyCreator(VerifyCreatorAccounts accounts, byte[] root, byte[] dataHash, byte[] creatorHash, ulong nonce, uint index, MetadataArgs message, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafOwner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Creator, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(14003103321588502836UL, offset);
                offset += 8;
                _data.WriteSpan(root, offset);
                offset += root.Length;
                _data.WriteSpan(dataHash, offset);
                offset += dataHash.Length;
                _data.WriteSpan(creatorHash, offset);
                offset += creatorHash.Length;
                _data.WriteU64(nonce, offset);
                offset += 8;
                _data.WriteU32(index, offset);
                offset += 4;
                offset += message.Serialize(_data, offset);
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction UnverifyCreator(UnverifyCreatorAccounts accounts, byte[] root, byte[] dataHash, byte[] creatorHash, ulong nonce, uint index, MetadataArgs message, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafOwner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Creator, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(10984406386623492715UL, offset);
                offset += 8;
                _data.WriteSpan(root, offset);
                offset += root.Length;
                _data.WriteSpan(dataHash, offset);
                offset += dataHash.Length;
                _data.WriteSpan(creatorHash, offset);
                offset += creatorHash.Length;
                _data.WriteU64(nonce, offset);
                offset += 8;
                _data.WriteU32(index, offset);
                offset += 4;
                offset += message.Serialize(_data, offset);
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction VerifyCollection(VerifyCollectionAccounts accounts, byte[] root, byte[] dataHash, byte[] creatorHash, ulong nonce, uint index, MetadataArgs message, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafOwner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionAuthorityRecordPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.EditionAccount, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.BubblegumSigner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(12212134156261749048UL, offset);
                offset += 8;
                _data.WriteSpan(root, offset);
                offset += root.Length;
                _data.WriteSpan(dataHash, offset);
                offset += dataHash.Length;
                _data.WriteSpan(creatorHash, offset);
                offset += creatorHash.Length;
                _data.WriteU64(nonce, offset);
                offset += 8;
                _data.WriteU32(index, offset);
                offset += 4;
                offset += message.Serialize(_data, offset);
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction UnverifyCollection(UnverifyCollectionAccounts accounts, byte[] root, byte[] dataHash, byte[] creatorHash, ulong nonce, uint index, MetadataArgs message, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafOwner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionAuthorityRecordPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.EditionAccount, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.BubblegumSigner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(12158180955007941626UL, offset);
                offset += 8;
                _data.WriteSpan(root, offset);
                offset += root.Length;
                _data.WriteSpan(dataHash, offset);
                offset += dataHash.Length;
                _data.WriteSpan(creatorHash, offset);
                offset += creatorHash.Length;
                _data.WriteU64(nonce, offset);
                offset += 8;
                _data.WriteU32(index, offset);
                offset += 4;
                offset += message.Serialize(_data, offset);
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction SetAndVerifyCollection(SetAndVerifyCollectionAccounts accounts, byte[] root, byte[] dataHash, byte[] creatorHash, ulong nonce, uint index, MetadataArgs message, PublicKey collection, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafOwner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionAuthorityRecordPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.EditionAccount, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.BubblegumSigner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(16912400468640658155UL, offset);
                offset += 8;
                _data.WriteSpan(root, offset);
                offset += root.Length;
                _data.WriteSpan(dataHash, offset);
                offset += dataHash.Length;
                _data.WriteSpan(creatorHash, offset);
                offset += creatorHash.Length;
                _data.WriteU64(nonce, offset);
                offset += 8;
                _data.WriteU32(index, offset);
                offset += 4;
                offset += message.Serialize(_data, offset);
                _data.WritePubKey(collection, offset);
                offset += 32;
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction Transfer(TransferAccounts accounts, byte[] root, byte[] dataHash, byte[] creatorHash, ulong nonce, uint index, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafOwner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NewLeafOwner, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(13422138168166593699UL, offset);
                offset += 8;
                _data.WriteSpan(root, offset);
                offset += root.Length;
                _data.WriteSpan(dataHash, offset);
                offset += dataHash.Length;
                _data.WriteSpan(creatorHash, offset);
                offset += creatorHash.Length;
                _data.WriteU64(nonce, offset);
                offset += 8;
                _data.WriteU32(index, offset);
                offset += 4;
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction Delegate(DelegateAccounts accounts, byte[] root, byte[] dataHash, byte[] creatorHash, ulong nonce, uint index, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafOwner, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.PreviousLeafDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NewLeafDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(9873113408189731674UL, offset);
                offset += 8;
                _data.WriteSpan(root, offset);
                offset += root.Length;
                _data.WriteSpan(dataHash, offset);
                offset += dataHash.Length;
                _data.WriteSpan(creatorHash, offset);
                offset += creatorHash.Length;
                _data.WriteU64(nonce, offset);
                offset += 8;
                _data.WriteU32(index, offset);
                offset += 4;
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction Burn(BurnAccounts accounts, byte[] root, byte[] dataHash, byte[] creatorHash, ulong nonce, uint index, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafOwner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(6713419448098582132UL, offset);
                offset += 8;
                _data.WriteSpan(root, offset);
                offset += root.Length;
                _data.WriteSpan(dataHash, offset);
                offset += dataHash.Length;
                _data.WriteSpan(creatorHash, offset);
                offset += creatorHash.Length;
                _data.WriteU64(nonce, offset);
                offset += 8;
                _data.WriteU32(index, offset);
                offset += 4;
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction Redeem(RedeemAccounts accounts, byte[] root, byte[] dataHash, byte[] creatorHash, ulong nonce, uint index, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.LeafOwner, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Voucher, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(16240477538706918584UL, offset);
                offset += 8;
                _data.WriteSpan(root, offset);
                offset += root.Length;
                _data.WriteSpan(dataHash, offset);
                offset += dataHash.Length;
                _data.WriteSpan(creatorHash, offset);
                offset += creatorHash.Length;
                _data.WriteU64(nonce, offset);
                offset += 8;
                _data.WriteU32(index, offset);
                offset += 4;
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction CancelRedeem(CancelRedeemAccounts accounts, byte[] root, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.LeafOwner, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Voucher, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(17451641138953342063UL, offset);
                offset += 8;
                _data.WriteSpan(root, offset);
                offset += root.Length;
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction DecompressV1(DecompressV1Accounts accounts, MetadataArgs metadata, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Voucher, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.LeafOwner, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.TokenAccount, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Mint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.MintAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Metadata, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SysvarRent, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.AssociatedTokenProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(5883102871591605558UL, offset);
                offset += 8;
                offset += metadata.Serialize(_data, offset);
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }

            public static Solana.Unity.Rpc.Models.TransactionInstruction Compress(CompressAccounts accounts, PublicKey programId)
            {
                List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TreeAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafOwner, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LeafDelegate, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.MerkleTree, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.TokenAccount, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Mint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Metadata, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.LogWrapper, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CompressionProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
                byte[] _data = new byte[1200];
                int offset = 0;
                _data.WriteU64(18262964761550438738UL, offset);
                offset += 8;
                byte[] resultData = new byte[offset];
                Array.Copy(_data, resultData, offset);
                return new Solana.Unity.Rpc.Models.TransactionInstruction{Keys = keys, ProgramId = programId.KeyBytes, Data = resultData};
            }
        }
    }