using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using EOS.Client.Models;
using EOS.Client.Utils;
using RestSharp;
using RestSharp.Serialization.Json;
using Action = EOS.Client.Models.Action;
using Hex = EOS.Client.Cryptography.Hex;

namespace EOS.Client
{
    public class EosClient
    {
        public EosClient() : this(new Uri("http://localhost:8888"))
        {
        }


        public EosClient(Uri nodeUri)
        {
            this.Api = new EosApi(nodeUri);
            this.serializer = new EosBinarySerializer(this.Api);
        }

        public IEosApi Api { get; }

        public async Task<string> PushActionsAsync(IEnumerable<Action> actions)
        {

            var chainInfo = await Api.GetInfoAsync();
            var blockInfo = await Api.GetBlockAsync(chainInfo.LastIrreversibleBlockId);

            var transaction = new Transaction
            {
                RefBlockNum = chainInfo.LastIrreversibleBlockNum,
                RefBlockPrefix = blockInfo.RefBlockPrefix,
                Expiration = chainInfo.HeadBlockTime.AddSeconds(30),
                Actions = actions
            };

            return await PushTransactionAsync(transaction, chainInfo.ChainId);
        }

        public async Task<string> PushTransactionAsync(Transaction transaction)
        {
            cachedChainInfo = cachedChainInfo ?? await Api.GetInfoAsync();

            return await PushTransactionAsync(transaction, cachedChainInfo.ChainId);
        }

        async Task<string> PushTransactionAsync(Transaction transaction, string chainId)
        {
            var packedTransaction = await serializer.SerializeAsync(transaction);
            var packed_trx = Hex.Encode(packedTransaction);
            return packed_trx;
        }

        private readonly EosBinarySerializer serializer;
        ChainInfo cachedChainInfo;
    }

    public class SignatureAW
    {
        public List<string> signatures { get; set; }
    }
}