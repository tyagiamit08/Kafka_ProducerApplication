﻿namespace Kafka.Constants
{
	/// <summary>
	/// Represents the list of topics in Kafka
	/// </summary>
	public static class KafkaTopics
	{
		/// <summary>
		/// Denotes register user topic
		/// </summary>
		public static string RegisterUser => "RegisterUser";

		/// <summary>
		/// Denotes user registered topic
		/// </summary>
		public static string UserRegistered => "UserRegistered";
	}
}
