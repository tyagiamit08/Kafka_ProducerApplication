﻿using System.Threading.Tasks;
using Kafka.Constants;
using Kafka.Interfaces;
using Kafka.Messages.UserRegistration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Kafka_ProducerApplication.Controllers
{
	[ApiController]
	[Route("api/[controller]")]

	public class ApplicationController : ControllerBase
	{
		private readonly IKafkaProducer<string, UserRegistered> _kafkaProducer;
		public ApplicationController(IKafkaProducer<string, UserRegistered> kafkaProducer)
		{
			_kafkaProducer = kafkaProducer;
		}

		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[SwaggerOperation("Produce Kafka Message", "This endpoint can be used to produce dummy message in Kafka Topic")]
		public async Task<IActionResult> ProduceMessage(UserRegistered request)
		{
			await _kafkaProducer.ProduceAsync(KafkaTopics.UserRegistered, null, request);

			return Ok("User Registration In Progress");
		}
	}
}
