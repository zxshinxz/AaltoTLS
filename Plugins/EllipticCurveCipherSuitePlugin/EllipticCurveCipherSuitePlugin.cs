using System;
using System.Collections.Generic;
using AaltoTLS.PluginInterface;

namespace EllipticCurveCipherSuitePlugin
{
	public class EllipticCurveCipherSuitePlugin : CipherSuitePlugin
	{
		private readonly CipherSuiteInfo[] _cipherSuites = new CipherSuiteInfo[] {
			new CipherSuiteInfo(0xC001, "TLS_ECDH_ECDSA_WITH_NULL_SHA", "ECDH", "ECDSA", null, "SHA1"),
			new CipherSuiteInfo(0xC002, "TLS_ECDH_ECDSA_WITH_RC4_128_SHA", "ECDH", "ECDSA", "RC4_128", "SHA1"),
			new CipherSuiteInfo(0xC003, "TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA", "ECDH", "ECDSA", "3DES_EDE_CBC", "SHA1"),
			new CipherSuiteInfo(0xC004, "TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA", "ECDH", "ECDSA", "AES_128_CBC", "SHA1"),
			new CipherSuiteInfo(0xC005, "TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA", "ECDH", "ECDSA", "AES_256_CBC", "SHA1"),

			new CipherSuiteInfo(0xC006, "TLS_ECDHE_ECDSA_WITH_NULL_SHA", "ECDHE", "ECDSA", null, "SHA1"),
			new CipherSuiteInfo(0xC007, "TLS_ECDHE_ECDSA_WITH_RC4_128_SHA", "ECDHE", "ECDSA", "RC4_128", "SHA1"),
			new CipherSuiteInfo(0xC008, "TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA", "ECDHE", "ECDSA", "3DES_EDE_CBC", "SHA1"),
			new CipherSuiteInfo(0xC009, "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA", "ECDHE", "ECDSA", "AES_128_CBC", "SHA1"),
			new CipherSuiteInfo(0xC00A, "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA", "ECDHE", "ECDSA", "AES_256_CBC", "SHA1"),

			new CipherSuiteInfo(0xC00B, "TLS_ECDH_RSA_WITH_NULL_SHA", "ECDH", "RSA", null, "SHA1"),
			new CipherSuiteInfo(0xC00C, "TLS_ECDH_RSA_WITH_RC4_128_SHA", "ECDH", "RSA", "RC4_128", "SHA1"),
			new CipherSuiteInfo(0xC00D, "TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA", "ECDH", "RSA", "3DES_EDE_CBC", "SHA1"),
			new CipherSuiteInfo(0xC00E, "TLS_ECDH_RSA_WITH_AES_128_CBC_SHA", "ECDH", "RSA", "AES_128_CBC", "SHA1"),
			new CipherSuiteInfo(0xC00F, "TLS_ECDH_RSA_WITH_AES_256_CBC_SHA", "ECDH", "RSA", "AES_256_CBC", "SHA1"),

			new CipherSuiteInfo(0xC010, "TLS_ECDHE_RSA_WITH_NULL_SHA", "ECDHE", "RSA", null, "SHA1"),
			new CipherSuiteInfo(0xC011, "TLS_ECDHE_RSA_WITH_RC4_128_SHA", "ECDHE", "RSA", "RC4_128", "SHA1"),
			new CipherSuiteInfo(0xC012, "TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA", "ECDHE", "RSA", "3DES_EDE_CBC", "SHA1"),
			new CipherSuiteInfo(0xC013, "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA", "ECDHE", "RSA", "AES_128_CBC", "SHA1"),
			new CipherSuiteInfo(0xC014, "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA", "ECDHE", "RSA", "AES_256_CBC", "SHA1"),

			new CipherSuiteInfo(0xC015, "TLS_ECDH_anon_WITH_NULL_SHA", "ECDHE", null, null, "SHA1"),
			new CipherSuiteInfo(0xC016, "TLS_ECDH_anon_WITH_RC4_128_SHA", "ECDHE", null, "RC4_128", "SHA1"),
			new CipherSuiteInfo(0xC017, "TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA", "ECDHE", null, "3DES_EDE_CBC", "SHA1"),
			new CipherSuiteInfo(0xC018, "TLS_ECDH_anon_WITH_AES_128_CBC_SHA", "ECDHE", null, "AES_128_CBC", "SHA1"),
			new CipherSuiteInfo(0xC019, "TLS_ECDH_anon_WITH_AES_256_CBC_SHA", "ECDHE", null, "AES_256_CBC", "SHA1"),
			
			// These are from RFC 5289 for use with TLS 1.2 only
			new CipherSuiteInfo(0xC023, "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256", "ECDHE", "ECDSA", "TLS_SHA256", "AES_128_CBC", "SHA256"),
			new CipherSuiteInfo(0xC024, "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384", "ECDHE", "ECDSA", "TLS_SHA384", "AES_256_CBC", "SHA384"),
			new CipherSuiteInfo(0xC025, "TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256", "ECDHE", "ECDSA", "TLS_SHA256", "AES_128_CBC", "SHA256"),
			new CipherSuiteInfo(0xC026, "TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384", "ECDHE", "ECDSA", "TLS_SHA384", "AES_256_CBC", "SHA384"),
			
			new CipherSuiteInfo(0xC027, "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256", "ECDHE", "RSA", "TLS_SHA256", "AES_128_CBC", "SHA256"),
			new CipherSuiteInfo(0xC028, "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384", "ECDHE", "RSA", "TLS_SHA384", "AES_256_CBC", "SHA384"),
			new CipherSuiteInfo(0xC029, "TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256", "ECDHE", "RSA", "TLS_SHA256", "AES_128_CBC", "SHA256"),
			new CipherSuiteInfo(0xC02A, "TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384", "ECDHE", "RSA", "TLS_SHA384", "AES_256_CBC", "SHA384"),
			
			new CipherSuiteInfo(0xC02B, "TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256", "ECDHE", "ECDSA", "TLS_SHA256", "AES_128_GCM", null),
			new CipherSuiteInfo(0xC02C, "TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384", "ECDHE", "ECDSA", "TLS_SHA384", "AES_256_GCM", null),
			new CipherSuiteInfo(0xC02D, "TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256", "ECDHE", "ECDSA", "TLS_SHA256", "AES_128_GCM", null),
			new CipherSuiteInfo(0xC02E, "TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384", "ECDHE", "ECDSA", "TLS_SHA384", "AES_256_GCM", null),
			
			new CipherSuiteInfo(0xC02F, "TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256", "ECDHE", "RSA", "TLS_SHA256", "AES_128_GCM", null),
			new CipherSuiteInfo(0xC030, "TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384", "ECDHE", "RSA", "TLS_SHA384", "AES_256_GCM", null),
			new CipherSuiteInfo(0xC031, "TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256", "ECDHE", "RSA", "TLS_SHA256", "AES_128_GCM", null),
			new CipherSuiteInfo(0xC032, "TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384", "ECDHE", "RSA", "TLS_SHA384", "AES_256_GCM", null),
		};
		
		public override string PluginName
		{
			get { return "Elliptic curve cipher suite plugin"; }
		}

		public override UInt16[] SupportedCipherSuites
		{
			get {
				List<UInt16> suites = new List<UInt16>();
				foreach (CipherSuiteInfo info in _cipherSuites) {
					suites.Add(info.CipherSuiteID);
				}
				return suites.ToArray();
			}
		}

		public override string[] SupportedKeyExchangeAlgorithms
		{
			get { return new string[] { "ECDHE" }; }
		}

		public override string[] SupportedSignatureAlgorithms
		{
			get { return new string[] { "ECDSA" }; }
		}

		public override CipherSuiteInfo GetCipherSuiteFromID(UInt16 id)
		{
			foreach (CipherSuiteInfo cipherSuite in _cipherSuites) {
				if (cipherSuite.CipherSuiteID == id) {
					return cipherSuite;
				}
			}

			return null;
		}

		public override KeyExchangeAlgorithm GetKeyExchangeAlgorithm(string name)
		{
			if (name.Equals("ECDHE")) {
				return new KeyExchangeAlgorithmECDHE();
			} else {
				return null;
			}
		}

		public override SignatureAlgorithm GetSignatureAlgorithm(string name)
		{
			if (name.Equals("ECDSA")) {
				return new SignatureAlgorithmECDSA();
			} else {
				return null;
			}
		}
	}
}
