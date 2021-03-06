toc.dat                                                                                             0000600 0004000 0002000 00000007031 13663415074 0014451 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        PGDMP       8    +                x         
   ProjectUAS    10.12    10.12     �
           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false         �
           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false         �
           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false         �
           1262    25580 
   ProjectUAS    DATABASE     �   CREATE DATABASE "ProjectUAS" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_Indonesia.1252' LC_CTYPE = 'English_Indonesia.1252';
    DROP DATABASE "ProjectUAS";
             postgres    false                     2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false         �
           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    3                     3079    12924    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false         �
           0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    1         �            1259    25583    pengguna    TABLE     O  CREATE TABLE public.pengguna (
    id bigint NOT NULL,
    nama character varying(50),
    agama character varying(50),
    telepon character varying(15),
    jenis_kelamin character varying(20),
    email character varying(50),
    username character varying(50),
    password character varying(255),
    last_update_pengguna date
);
    DROP TABLE public.pengguna;
       public         postgres    false    3         �            1259    25581    pengguna_id_seq    SEQUENCE     x   CREATE SEQUENCE public.pengguna_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.pengguna_id_seq;
       public       postgres    false    3    197         �
           0    0    pengguna_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.pengguna_id_seq OWNED BY public.pengguna.id;
            public       postgres    false    196         n
           2604    25586    pengguna id    DEFAULT     j   ALTER TABLE ONLY public.pengguna ALTER COLUMN id SET DEFAULT nextval('public.pengguna_id_seq'::regclass);
 :   ALTER TABLE public.pengguna ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    197    196    197         �
          0    25583    pengguna 
   TABLE DATA               |   COPY public.pengguna (id, nama, agama, telepon, jenis_kelamin, email, username, password, last_update_pengguna) FROM stdin;
    public       postgres    false    197       2795.dat �
           0    0    pengguna_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.pengguna_id_seq', 9, true);
            public       postgres    false    196         p
           2606    25588    pengguna pengguna_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.pengguna
    ADD CONSTRAINT pengguna_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.pengguna DROP CONSTRAINT pengguna_pkey;
       public         postgres    false    197                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               2795.dat                                                                                            0000600 0004000 0002000 00000001224 13663415074 0014270 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	user	buddha	0883213	Laki-laki	2sisiham19@gosteitoy.ga	origin	123	\N
2	user1	buddha	088222000	Laki-laki	2sisiham11@gosteitoy.ga	origin	222	\N
3	useeraja	Islam	992221	Perempuan	2sisiham19@gosteitoy.gheheh	lakubangt	443322	\N
4	useeraja221	buddha	992221	Perempuan	2sisiham19@gosteitoy.gheheh	lakuba	5554	\N
5	useradmin	Other	00929	Other	akaaa@gmaail	akun smurf	12221	\N
6	budak kecil	Other	111212112	Other	upin@gmail	upindanipin	upincintameimei	\N
7	akunbau	Islam	112766	Laki-laki	ehsanaja@gamil	ehsancomel	ehsandanfizi	\N
8	aji	Islam	1121212	Other	2sisiham19@gosteitoy.ga	ikii	123	\N
9	wirawan	Islam	0883213	Laki-laki	2sisiham19@gosteitoy.ga	wawan	123	\N
\.


                                                                                                                                                                                                                                                                                                                                                                            restore.sql                                                                                         0000600 0004000 0002000 00000006174 13663415074 0015405 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        --
-- NOTE:
--
-- File paths need to be edited. Search for $$PATH$$ and
-- replace it with the path to the directory containing
-- the extracted data files.
--
--
-- PostgreSQL database dump
--

-- Dumped from database version 10.12
-- Dumped by pg_dump version 10.12

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

ALTER TABLE ONLY public.pengguna DROP CONSTRAINT pengguna_pkey;
ALTER TABLE public.pengguna ALTER COLUMN id DROP DEFAULT;
DROP SEQUENCE public.pengguna_id_seq;
DROP TABLE public.pengguna;
DROP EXTENSION plpgsql;
DROP SCHEMA public;
--
-- Name: public; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA public;


ALTER SCHEMA public OWNER TO postgres;

--
-- Name: SCHEMA public; Type: COMMENT; Schema: -; Owner: postgres
--

COMMENT ON SCHEMA public IS 'standard public schema';


--
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET default_tablespace = '';

SET default_with_oids = false;

--
-- Name: pengguna; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pengguna (
    id bigint NOT NULL,
    nama character varying(50),
    agama character varying(50),
    telepon character varying(15),
    jenis_kelamin character varying(20),
    email character varying(50),
    username character varying(50),
    password character varying(255),
    last_update_pengguna date
);


ALTER TABLE public.pengguna OWNER TO postgres;

--
-- Name: pengguna_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.pengguna_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.pengguna_id_seq OWNER TO postgres;

--
-- Name: pengguna_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.pengguna_id_seq OWNED BY public.pengguna.id;


--
-- Name: pengguna id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pengguna ALTER COLUMN id SET DEFAULT nextval('public.pengguna_id_seq'::regclass);


--
-- Data for Name: pengguna; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pengguna (id, nama, agama, telepon, jenis_kelamin, email, username, password, last_update_pengguna) FROM stdin;
\.
COPY public.pengguna (id, nama, agama, telepon, jenis_kelamin, email, username, password, last_update_pengguna) FROM '$$PATH$$/2795.dat';

--
-- Name: pengguna_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pengguna_id_seq', 9, true);


--
-- Name: pengguna pengguna_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pengguna
    ADD CONSTRAINT pengguna_pkey PRIMARY KEY (id);


--
-- PostgreSQL database dump complete
--

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    