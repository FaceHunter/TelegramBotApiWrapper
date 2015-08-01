using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramApiWrapper.Objects.Types
{
    public class Message
    {
        /// <summary>
        /// Unique message identifier
        /// </summary>
        public int message_id;

        /// <summary>
        /// Sender
        /// </summary>
        public User from;

        /// <summary>
        /// Date the message was sent in Unix time
        /// </summary>
        public int date;

        /// <summary>
        /// Conversation the message belongs to — user in case of a private message, GroupChat in case of a group
        /// </summary>
        public GroupChat chat;

        /// <summary>
        /// [Optional] For forwarded messages, sender of the original message
        /// </summary>
        public User forward_from;

        /// <summary>
        /// [Optional] For forwarded messages, date the original message was sent in Unix time
        /// </summary>
        public int forward_date;

        /// <summary>
        /// [Optional] For replies, the original message. Note that the Message object in this field will not contain further reply_to_message fields even if it itself is a reply.
        /// </summary>
        public Message reply_to_message;

        /// <summary>
        /// [Optional] For text messages, the actual UTF-8 text of the message
        /// </summary>
        public string text;

        /// <summary>
        /// [Optional] Message is an audio file, information about the file
        /// </summary>
        public Audio audio;

        /// <summary>
        /// [Optional] Message is a general file, information about the file
        /// </summary>
        public Document document;

        /// <summary>
        /// [Optional] Message is a photo, available sizes of the photo
        /// </summary>
        public PhotoSize[] photo;

        /// <summary>
        /// [Optional] Message is a sticker, information about the sticker
        /// </summary>
        public Sticker sticker;

        /// <summary>
        /// [Optional] Message is a video, information about the video
        /// </summary>
        public Video video;

        /// <summary>
        /// [Optional] Caption for the photo or video
        /// </summary>
        public string caption;

        /// <summary>
        /// [Optional] Message is a shared contact, information about the contact
        /// </summary>
        public Contact contact;

        /// <summary>
        /// [Optional] Message is a shared location, information about the location
        /// </summary>
        public Location location;

        /// <summary>
        /// [Optional] A new member was added to the group, information about them (this member may be bot itself)
        /// </summary>
        public User new_chat_participant;

        /// <summary>
        /// [Optional] A member was removed from the group, information about them (this member may be bot itself)
        /// </summary>
        public User left_chat_participant;

        /// <summary>
        /// [Optional] A group title was changed to this value
        /// </summary>
        public string new_chat_title;

        /// <summary>
        /// [Optional] A group photo was change to this value
        /// </summary>
        public PhotoSize[] new_chat_photo;

        /// <summary>
        /// [Optional] Informs that the group photo was deleted
        /// </summary>
        public bool delete_chat_photo;

        /// <summary>
        /// [Optional] Informs that the group has been created
        /// </summary>
        public bool group_chat_created;
    }
}
